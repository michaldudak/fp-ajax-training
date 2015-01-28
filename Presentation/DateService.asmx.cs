using System;
using System.Web.Script.Services;
using System.Web.Services;

namespace AjaxWorkshop
{
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[ScriptService]
	public class DateService : WebService
	{
		[WebMethod]
		public string GetTime()
		{
			return DateTime.Now.ToLongTimeString();
		}
	}
}
