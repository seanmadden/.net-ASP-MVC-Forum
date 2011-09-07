using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Forum.Controllers
{
	public class HomeController : Controller
	{
		public RedirectResult Index()
		{
			return new RedirectResult("/boards");
		}

		public ActionResult About()
		{
			return View();
		}
	}
}
