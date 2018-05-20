using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web2.Middleware
{
	public class CustomResolver : IDependencyResolver
	{
		public object GetService(Type serviceType)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<object> GetServices(Type serviceType)
		{
			throw new NotImplementedException();
		}
	}
}