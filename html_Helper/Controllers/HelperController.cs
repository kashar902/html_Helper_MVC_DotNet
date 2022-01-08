using html_Helper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace html_Helper.Controllers
{
    public class HelperController : Controller
    {
        // GET: Helper
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Show()
        {
            return View();
        }

        public ActionResult Standardd()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Stgstd()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Stgstd(Employee emp)
        {
            return View();
        }

    }
}