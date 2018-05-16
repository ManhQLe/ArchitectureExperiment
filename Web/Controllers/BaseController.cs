using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MultiClientArchitecture.Factory;
using MultiClientArchitecture;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class BaseController : Controller
    {
		readonly IClientFactory _factory;

		public BaseController(IClientFactory factory) {
			_factory = factory;
		}

		protected T GetInstance<T>() {
			return DependencyResolver.Current.GetService<T>();
		}

		

		protected T GetClientService<T>() where T:IClientIdentity {
			int x = User.Identity.Name == "120" ? 110 : 111;
			return _factory.GetClientEntity<T>(x);
		}
    }
}