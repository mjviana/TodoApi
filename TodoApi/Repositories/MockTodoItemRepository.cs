using System;
using System.Collections.Generic;
using TodoApi.Models;

namespace TodoApi.Repositories
{
    public class MockTodoItemRepository : ITodoItemRepository
    {
        public IEnumerable<TodoItem> GetAllTodoItems()
        {
            return new List<TodoItem> {
                new TodoItem
                {
                    Id = 0,
                    Name = "Wash the car",
                    CreationDate = new DateTime(2020, 07, 13, 10, 28, 10),
                    IsComplete = false,
                },
                new TodoItem
                {
                    Id = 1,
                    Name = "Grocery shopping",
                    CreationDate = new DateTime(2020, 07, 13, 10, 30, 10),
                    IsComplete = false,
                }
            };
        }

        public TodoItem GetTodoItemById(int id)
        {
            return new TodoItem
            {
                Id = 0,
                Name = "Wash the car",
                CreationDate = new DateTime(2020, 07, 13, 10, 28, 10),
                IsComplete = false,
            };
        }
    }
}
