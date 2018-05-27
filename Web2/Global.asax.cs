using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Web2.Middleware;
using Ninject;
namespace Web2
{
	public class MvcApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);
					

			IKernel k = new StandardKernel();
			DIRegistry.RegisterDependencies(k);
			DependencyResolver.SetResolver(new CustomResolver(k));

			ControllerBuilder.Current.SetControllerFactory(new CustomControllerFac());
		
		}				
	}
}
