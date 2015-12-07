using System;
using System.Collections.Generic;
using System.Linq;

namespace TodoList
{
	/// <summary>
	/// Provides methods to interact with todos.
	/// </summary>
	public sealed class TodoRepository
	{
		private static readonly Dictionary<Guid, Todo> _todos = new Dictionary<Guid, Todo>();

		/// <summary>
		/// Gets all the todos defined in the system.
		/// </summary>
		public IEnumerable<Todo> GetAll()
		{
			return _todos.Values.ToArray();
		}

		/// <summary>
		/// Gets the to-do item by its id.
		/// </summary>
		/// <param name="id">The id of the to-do item to get.</param>
		public Todo Get(Guid id)
		{
			return _todos[id];
		}

		/// <summary>
		/// Creates a new to-do item.
		/// </summary>
		/// <param name="description">The description of the to-do item.</param>
		public Todo Add(string description)
		{
			Todo todo = new Todo(description);
			_todos.Add(todo.Id, todo);
			return todo;
		}

		/// <summary>
		/// Deletes the to-do item.
		/// </summary>
		/// <param name="id">The id of the to-do item to delete.</param>
		public void Remove(Guid id)
		{
			_todos.Remove(id);
		}

		/// <summary>
		/// Updates the to-do item.
		/// </summary>
		/// <param name="todo">The item to update.</param>
		public void Update(Todo todo)
		{
			_todos[todo.Id] = todo;
		}
	}
}
