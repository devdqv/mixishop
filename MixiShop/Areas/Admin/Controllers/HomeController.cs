using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MixiShop.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListProduct()
        {
            return View();
        }

        public ActionResult ManageCategory()
        {
            return View();
        }

        public ActionResult ManageOrder()
        {
            return View();
        }

        public ActionResult Detail()
        {
            return View();
        }

        public ActionResult Customers()
        {
            return View();
        }

        public ActionResult AddCategory()
        {
            return View();
        }


    }
}