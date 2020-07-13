using System.Collections.Generic;
using TodoApi.Models;

namespace TodoApi.Repositories
{
    public interface ITodoItemRepository
    {
        /// <summary>
        /// Gets all the todo items
        /// </summary>
        /// <returns></returns>
        IEnumerable<TodoItem> GetAllTodoItems();

        /// <summary>
        /// Gets a todo item by an id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TodoItem GetTodoItemById(int id);
    }
}
