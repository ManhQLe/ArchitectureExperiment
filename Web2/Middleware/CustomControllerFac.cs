using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Web2.Middleware
{
	public class CustomControllerFac: DefaultControllerFactory
	{
		protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
		{
			var x = DependencyResolver.Current;
			

			return base.GetControllerInstance(requestContext, controllerType);			
		}
	}
}