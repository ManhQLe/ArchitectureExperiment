using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject;
using Architecture2;
using Architecture2.Impl;
using Architecture2.Provider;
using Web2.Plugins;
namespace Web2.Middleware
{
	public class DIRegistry
	{
		public static void RegisterDependencies(IKernel kernel) {

			kernel.Bind<IMySampleRepo>().To<MySampleClientRepo>();
			kernel.Bind<ICentralRepository>().To<AdminRepository>();
			kernel.Bind<IConnectionStringProvider>().To<WebConfigProvider>();

		}
	}
}