using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace Web2.Middleware
{
	public class CustomControllerFac: DefaultControllerFactory
	{
		public object o = new object();

		protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
		{
			int ThreadId = Thread.CurrentThread.ManagedThreadId;
			Debug.WriteLine("Thread: " + ThreadId + " is entering...");
			lock (o) {
				Debug.WriteLine(ThreadId +" is working...");
				Thread.Sleep(3000);
			}
			Debug.WriteLine(ThreadId + " is done");
			
			return base.GetControllerInstance(requestContext, controllerType);			
		}
	}
}