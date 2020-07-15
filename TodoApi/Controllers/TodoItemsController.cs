using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi;
using TodoApi.DbContexts;
using TodoApi.Dtos;
using TodoApi.Models;
using TodoApi.Repositories;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoItemsController : ControllerBase
    {
        private readonly ITodoItemRepository _todoItemRepository;
        private readonly IMapper _mapper;

        public TodoItemsController(ITodoItemRepository todoItemRepository, IMapper mapper)
        {
            _todoItemRepository = todoItemRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TodoItemDto>> GetTodoItems()
        {
            var todoItems = _todoItemRepository.GetAllTodoItems();

            return Ok(_mapper.Map<IEnumerable<TodoItemDto>>(todoItems));
        }

        [HttpGet("{id}", Name = "GetTodoItem")]
        public ActionResult<TodoItemDto> GetTodoItem(int id)
        {
            var todoItem = _todoItemRepository.GetTodoItemById(id);

            if (todoItem == null)
                return NotFound();

            return Ok(_mapper.Map<TodoItemDto>(todoItem));
        }

        [HttpPost]
        public ActionResult<TodoItemDto> CreateTodoItem(TodoItemDto todoItem)
        {
            var todoItemModel = _mapper.Map<TodoItem>(todoItem);

            _todoItemRepository.CreateTodoItem(todoItemModel);
            _todoItemRepository.SaveChanges();

            var todoItemDto = _mapper.Map<TodoItemDto>(todoItemModel);

            return CreatedAtRoute(nameof(GetTodoItem), new { todoItemDto.Id }, todoItemDto);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateTodoItem(int id, TodoItemUpdateDto todoItemUpdate)
        {
            var todoItemModel = _todoItemRepository.GetTodoItemById(id);

            if (todoItemModel == null)
            {
                return NotFound();
            }

            // Updates the model from the repository, with the values of the dto object that was sent
            _mapper.Map(todoItemUpdate, todoItemModel);

            _todoItemRepository.UpdateTodoItem(todoItemModel);

            _todoItemRepository.SaveChanges();

            return NoContent();
        }
    }
}
