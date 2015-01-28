using System;
using System.Web.Http;

namespace AjaxWorkshop.Controllers
{
	public class TimeApiController : ApiController
	{
		public string Post()
		{
			return DateTime.Now.ToLongTimeString();
		}
	}
}