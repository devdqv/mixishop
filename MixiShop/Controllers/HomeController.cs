using MixiShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MixiShop.Controllers
{
    public class HomeController : Controller
    {
        mixishopEntities db = new mixishopEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NavPartial()
        {
            return PartialView(db.Categories.ToList());
        }

        public ActionResult ProductDetail()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Account()
        {
            return View();
        }


    }
}