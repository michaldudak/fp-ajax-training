using System;
using System.Web;
using System.Web.Routing;
using System.Web.Http;
using System.Web.Mvc;

namespace AjaxWorkshop
{
	public class Global : HttpApplication
	{
		protected void Application_Start(object sender, EventArgs e)
		{
			RouteTable.Routes.MapHttpRoute("ApiDefault", "API/{controller}");
			RouteTable.Routes.MapHttpRoute("ApiWithAction", "API/{controller}/{action}");
			RouteTable.Routes.MapRoute("MvcDefault", "{controller}/{action}", new { action = "Index" });
		}
	}
}