using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web;
using Web.Registry;

namespace Web
{
	public class DependencyConfig
	{
		public static void RegisterResolver() {
			DependencyResolver.SetResolver(DIRegistry.WebDependencyResolver);
		}
	}
}