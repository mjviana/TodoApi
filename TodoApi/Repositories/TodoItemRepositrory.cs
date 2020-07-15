using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.DbContexts;
using TodoApi.Models;

namespace TodoApi.Repositories
{
    public class TodoItemRepositrory : ITodoItemRepository
    {
        private readonly TodoContext _context;

        public TodoItemRepositrory(TodoContext context)
        {
            _context = context;
        }

        public IEnumerable<TodoItem> GetAllTodoItems()
        {
            return _context.TodoItems.ToList();
        }

        public TodoItem GetTodoItemById(int id)
        {
            return _context.TodoItems.FirstOrDefault(tdi => tdi.Id == id);
        }
    }
}
