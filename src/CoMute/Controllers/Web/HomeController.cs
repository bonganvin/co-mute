using CoMute.Web.Models.Dto;
using CoMute.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace CoMute.Web.Controllers.Web
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult ViewCarpools()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
    }
}