using System;
using System.Collections.Generic;
using System.Linq;
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

        public void CreateTodoItem(TodoItem todoItem)
        {
            if (todoItem == null)
                throw new ArgumentNullException(nameof(todoItem));

            todoItem.CreationDate = DateTime.Now;
            todoItem.CompletationDate = new DateTime(2000, 02, 02);
            todoItem.IsComplete = false;

            _context.TodoItems.Add(todoItem);
        }

        public IEnumerable<TodoItem> GetAllTodoItems()
        {
            return _context.TodoItems.ToList();
        }

        public TodoItem GetTodoItemById(int id)
        {
            return _context.TodoItems.FirstOrDefault(tdi => tdi.Id == id);
        }
        public void UpdateTodoItem(TodoItem todoItem)
        {
            // Nothing
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
