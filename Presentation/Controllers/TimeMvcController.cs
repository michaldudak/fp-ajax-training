using System;
using System.Web.Mvc;

namespace AjaxWorkshop.Controllers
{
	public class TimeMvcController : Controller
	{
		public ActionResult Index()
		{
			var data = DateTime.Now.ToLongTimeString();
			return Json(data);
		}
	}
}