using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading;
using Architecture2;
using System.Diagnostics;
using Ninject;
namespace Web2.Middleware
{
	public class CustomResolver : IDependencyResolver
	{
		readonly IKernel _kernel;
		public CustomResolver(IKernel kernel) {
			_kernel = kernel;
		}

		public object GetService(Type serviceType)
		{			
			object o = null;
			try
			{
				o =  _kernel.Get(serviceType);				
			}
			catch
			{
				Debug.WriteLine("Not found");				
			}
			return o;
		}

		public IEnumerable<object> GetServices(Type serviceType)
		{
			try
			{
				return _kernel.GetAll(serviceType);
			}
			catch {
				return new List<object>();
			}
		}
	}
}