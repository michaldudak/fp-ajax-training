using System;

namespace TodoList
{
	/// <summary>
	/// Represents a single to-do item.
	/// </summary>
	public sealed class Todo
	{
		internal Todo(string description)
		{
			Id = Guid.NewGuid();
			IsCompleted = false;
			Description = description;
		}

		/// <summary>
		/// Gets the system-unique id of the to-do.
		/// </summary>
		public Guid Id { get; private set; }

		/// <summary>
		/// Gets the description of the to-do.
		/// </summary>
		public string Description { get; internal set; }

		/// <summary>
		/// Gets a value indicating whether this to-do has been completed.
		/// </summary>
		public bool IsCompleted { get; set; }
	}
}
