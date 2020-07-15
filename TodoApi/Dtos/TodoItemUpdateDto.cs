using System.ComponentModel.DataAnnotations;

namespace TodoApi.Dtos
{
    public class TodoItemUpdateDto
    {
        /// <summary>
        /// Name of the todo item
        /// </summary>
        [Required]
        public string Name { get; set; }
    }
}
