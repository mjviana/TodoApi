using AutoMapper;
using TodoApi.Dtos;
using TodoApi.Models;

namespace TodoApi.Mappings
{
    public class TodoItemsMapping : Profile
    {
        public TodoItemsMapping()
        {
            CreateMap<TodoItem, TodoItemDto>();
            CreateMap<TodoItemDto, TodoItem>();
        }
    }
}
