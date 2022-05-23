using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using technologyMarket.BusinessLayer.Concrete;
using PagedList;
using PagedList.Mvc;

namespace technologyMarket.Controllers
{
    public class HomeController : Controller
    {
        //ProductRepository productRepository = new ProductRepository();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Checkout()
        {
            return View();
        }

        public ActionResult Store()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}                                    