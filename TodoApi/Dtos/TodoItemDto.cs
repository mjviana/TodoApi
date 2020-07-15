using System.ComponentModel.DataAnnotations;

namespace TodoApi.Dtos
{
    public class TodoItemDto
    {
        /// <summary>
        /// Id of the todo item
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the todo item
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Todo item  complete?
        /// </summary>
        public bool IsComplete { get; set; }
    }
}
