﻿namespace TodoApi
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
    }
}
