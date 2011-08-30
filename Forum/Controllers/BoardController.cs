using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Forum.Controllers
{
    public class BoardController : Controller
    {
        //
        // GET: /Default1/

        public ActionResult Index()
        {
            
            return View();
           
        }

        public ActionResult Board(string name, int times)
        {
            ViewBag.Message = "hello " + name;
            ViewBag.numTimes = times;

            return View(); 
        }



    }
}
