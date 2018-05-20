using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading;
using System.Diagnostics;
using Ninject;
namespace Web2.Middleware
{
	public class CustomResolver : IDependencyResolver
	{
		public int _Id = 0;
		
		public int Id {
			get { return _Id; }
			set {

				if (_Id > 0)
				{
					lock (this)
					{
						_Id = value;
					}
				}
			}
		}


		public object GetService(Type serviceType)
		{
			Debug.WriteLine("Thread: " + Thread.CurrentThread.ManagedThreadId + " getting service for " + serviceType);

			return null;
		}

		public IEnumerable<object> GetServices(Type serviceType)
		{
			return null;
		}
	}
}