using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models; 

namespace WebApplication6.Controllers
{
    public class HomeController : Controller
    {
        pubsEntities ob = new pubsEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult getdata()
        {
            List<view_titles> data = ob.view_titles.ToList<view_titles>();
            return Json(new {data}, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Postdata(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Postdata()
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