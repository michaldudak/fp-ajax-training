using System;
using System.Web.Script.Services;
using System.Web.Services;

namespace AjaxWorkshop
{
	public class Person
	{
		public string FirstName { get; set; }

		public string LastName { get; set; }
	}

	[ScriptService]
	public class Playground : WebService
	{
		[WebMethod]
		public string PlayWithParams(string firstName, string lastName)
		{
			return string.Format("Hello, {0} {1}!", firstName, lastName);
		}

		[WebMethod]
		public Person PlayWithoutParams()
		{
			return new Person { FirstName = "Sheldon", LastName = "Cooper" };
		}

		[WebMethod]
		public string PlayWithComplexParams(Person person)
		{
			return string.Format("Hello, {0} {1}!", person.FirstName, person.LastName);
		}
	}
}
