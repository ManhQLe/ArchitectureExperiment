using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Architecture2;
using Architecture2.Impl;

namespace Web2.Controllers
{
    public class TestController : DIController
    {
		ICentralRepository _centralRepo;
		IMySampleRepo _repo;
		public TestController(ICentralRepository centralRepo, IMySampleRepo repo) {
			_centralRepo = centralRepo;
		}

        // GET: Test
        public ActionResult Index()
        {
			ViewBag.Message = _centralRepo.ToString() + " " +((IClientEntity)_repo).Client.Name;
            return View();
        }
    }
}