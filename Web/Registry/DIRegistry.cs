using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MultiClientArchitecture.Factory;
using Ninject;

namespace Web.Registry
{
	public class DIRegistry
	{
		public static void RegisterDependencies(IKernel kernel) {

		}

		public static IDependencyResolver WebDependencyResolver
		{
			get
			{
				IKernel kernel = new StandardKernel();				

				DIRegistry.RegisterDependencies(kernel);
				return new MagicResolver(kernel);
			}
		}
	}
}