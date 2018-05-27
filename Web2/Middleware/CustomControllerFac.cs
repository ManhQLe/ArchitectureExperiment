using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Threading;
using System.Diagnostics;
using System.IO;
using Ninject;
using Ninject.Activation.Blocks;
using Ninject.Activation;

namespace Web2.Middleware
{
	public class X : StandardKernel{
		public override IEnumerable<object> Resolve(IRequest request)
		{
			
			return base.Resolve(request);
		}
	}

	public class CustomControllerFac: DefaultControllerFactory
	{
		private readonly IKernel _kernel;

		public CustomControllerFac(IKernel kernel) {
			_kernel = kernel;
		}

		protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
		{
			var constructor = controllerType.GetConstructors().First();

			var parameters = constructor
		   .GetParameters()
		   .Select(argument => _kernel.GetService(argument.ParameterType))
		   .ToArray();
						
			return (IController)constructor.Invoke(parameters);
		}
	}
}