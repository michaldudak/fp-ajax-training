using System;
using System.Web.Http;
using System.Web.Mvc;

using TodoList;

namespace AjaxWorkshop.Controllers
{
	public class TodosController : Controller
	{
		private readonly TodoRepository todoRepository = new TodoRepository();
		
		public ActionResult All()
		{
			return Json(this.todoRepository.GetTodos(), JsonRequestBehavior.AllowGet);
		}

		public ActionResult Create(string description)
		{
			return Json(this.todoRepository.AddTodo(description));
		}

		public ActionResult Delete([FromBody] Guid id)
		{
			this.todoRepository.DeleteTodo(id);
			return new EmptyResult();
		}

		public ActionResult ToggleCompletionStatus(Guid id, bool isCompleted)
		{
			var todo = todoRepository.GetTodo(id);
			todo.IsCompleted = isCompleted;
			
			todoRepository.UpdateTodo(todo);

			return new EmptyResult();
		}
	}	
}