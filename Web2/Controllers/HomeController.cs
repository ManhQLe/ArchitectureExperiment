using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;
using System.Web.Mvc;
using System.Web.Routing;
using Architecture2.Impl;
using Architecture2;

namespace Web2.Controllers
{
	public class HomeController : Controller
	{
		readonly IMySampleRepo _repo;
		public HomeController(IMySampleRepo repo) {
			Debug.WriteLine("CALLED");
			_repo = repo;
			
		}

		public ActionResult Index()
		{
			ViewBag.Message = _repo.ToString() + "  " 
				+ ((IClientEntity)_repo).Client.Name;
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