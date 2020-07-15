using System;
using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models
{
    public class TodoItem
    {
        /// <summary>
        /// Id of the todo item
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Name of the todo item
        /// </summary>
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        /// <summary>
        /// Todo item  complete?
        /// </summary>
        [Required]
        public bool IsComplete { get; set; }

        /// <summary>
        /// Date when the to do item was created
        /// </summary>
        [Required]
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Date when the todo item was completed
        /// </summary>
        public DateTime CompletationDate { get; set; }
    }
}
