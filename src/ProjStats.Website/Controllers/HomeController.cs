﻿using System.Web.Mvc;

namespace ProjStats.Website.Controllers
{
    public class HomeController : Controller
    {
         public ActionResult Index()
         {
             return View();
         }

        [Route("loop")]
        public ActionResult Loop()
        {
            return View();
        }
    }
}