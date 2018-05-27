using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Reflection;
using System.Diagnostics;
using System.Web.Routing;

namespace Web2.Controllers
{
    public class DIController : Controller
    {
		public DIController() {
			Type t = this.GetType();
			var members = t.GetMembers(BindingFlags.Instance | BindingFlags.NonPublic);
			foreach (var mem in members) {

			}
		}
		
	}
}