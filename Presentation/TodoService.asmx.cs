using System.Web.Script.Services;
using System.Web.Services;
using Newtonsoft.Json;

using TodoList;

namespace AjaxWorkshop
{
	[ScriptService]
	public class TodoService : WebService
	{
		[WebMethod]
		[ScriptMethod(UseHttpGet = true)]
		public string Todos()
		{
			TodoRepository todos = new TodoRepository();
			todos.AddTodo("foo");
			todos.AddTodo("bar");

			var tasks = todos.GetTodos();

			return JsonConvert.SerializeObject(tasks);
		}
	}
}
