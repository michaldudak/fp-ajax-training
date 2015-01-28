using System;
using System.Collections.Generic;
using System.Linq;

namespace TodoList
{
	/// <summary>
	/// Provides methods to interact with tasks.
	/// </summary>
	public sealed class TodoRepository
	{
		private static readonly Dictionary<Guid, Todo> Tasks = new Dictionary<Guid, Todo>();

		/// <summary>
		/// Gets all the tasks defined in the system.
		/// </summary>
		public IEnumerable<Todo> GetTodos()
		{
			return Tasks.Values.ToArray();
		}

		/// <summary>
		/// Creates a new task.
		/// </summary>
		/// <param name="description">The description of the to-do item.</param>
		public Todo AddTodo(string description)
		{
			Todo todo = new Todo(description);
			Tasks.Add(todo.Id, todo);
			return todo;
		}

		/// <summary>
		/// Gets the task by its id.
		/// </summary>
		/// <param name="id">The id of the to-do item to get.</param>
		public Todo GetTodo(Guid id)
		{
			return Tasks[id];
		}

		/// <summary>
		/// Deletes the task.
		/// </summary>
		/// <param name="id">The id of the to-do item to delete.</param>
		public void DeleteTodo(Guid id)
		{
			Tasks.Remove(id);
		}

		/// <summary>
		/// Updates the to-do item.
		/// </summary>
		/// <param name="todo">The item to update.</param>
		public void UpdateTodo(Todo todo)
		{
			Tasks[todo.Id] = todo;
		}
	}
}
