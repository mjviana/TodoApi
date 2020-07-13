using System;

namespace TodoApi.Models
{
    public class TodoItem
    {
        /// <summary>
        /// Id of the todo item
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the todo item
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Todo item  complete?
        /// </summary>
        public bool IsComplete { get; set; }

        /// <summary>
        /// Date when the to do item was created
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Date when the todo item was completed
        /// </summary>
        public DateTime CompletationDate { get; set; }
    }
}
