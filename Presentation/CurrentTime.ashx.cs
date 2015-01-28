using System;
using System.Web;

namespace AjaxWorkshop
{
	public class CurrentTime : IHttpHandler
	{
		public void ProcessRequest(HttpContext context)
		{
			string response = "\"" + DateTime.Now.ToLongTimeString() + "\"";
			
			context.Response.ContentType = "application/json";
			context.Response.Write(response);
		}

		public bool IsReusable
		{
			get { return true; }
		}
	}
}