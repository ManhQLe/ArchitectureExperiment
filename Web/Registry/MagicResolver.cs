using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Ninject;

namespace Web.Registry
{
	public class NinjectResolver: IDependencyResolver
	{
		readonly IKernel _kernel;

		public NinjectResolver(IKernel kernel) {
			_kernel = kernel;
		}

		public object GetService(Type serviceType)
		{
			return _kernel.Get(serviceType);
		}

		public IEnumerable<object> GetServices(Type serviceType)
		{
			return _kernel.GetAll(serviceType);
		}		
	}
}