using System;
using System.Web.Http;
using System.Web.Mvc;

using TodoList;

namespace AjaxWorkshop.Controllers
{
	public class TodosController : Controller
	{
		private readonly TodoRepository _todoRepository = new TodoRepository();
		
		public ActionResult All()
		{
			return Json(_todoRepository.GetAll(), JsonRequestBehavior.AllowGet);
		}

		public ActionResult Create(string description)
		{
			return Json(_todoRepository.Add(description));
		}

		public ActionResult Delete([FromBody] Guid id)
		{
			_todoRepository.Remove(id);
			return new EmptyResult();
		}

		public ActionResult ToggleCompletionStatus(Guid id, bool isCompleted)
		{
			var todo = _todoRepository.Get(id);
			todo.IsCompleted = isCompleted;
			
			_todoRepository.Update(todo);

			return new EmptyResult();
		}
	}	
}