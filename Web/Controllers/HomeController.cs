using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MultiClientArchitecture.Factory;
using MultiClientArchitecture.BusinessService;
using System.Web.Mvc;

namespace Web.Controllers
{
	public class HomeController : BaseController
	{
		readonly IBusinessService1 _businessService;
		public HomeController(IClientFactory f):base(f) {
			
		}

		public ActionResult Index()
		{
			
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}