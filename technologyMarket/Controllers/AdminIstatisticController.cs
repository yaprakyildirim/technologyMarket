using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using technologyMarket.DataAccessLayer.Context;

namespace technologyMarket.Controllers
{
    [Authorize(Roles="Admin")]
    public class AdminIstatisticController : Controller
    {
        // GET: AdminIstatistic
        DataContext db = new DataContext();
        public ActionResult Index()
        {
            var satis = db.Sales.Count();
            ViewBag.satis = satis;

            var urun = db.Products.Count();
            ViewBag.urun = urun;

            var kategori = db.Categories.Count();
            ViewBag.kategori = kategori;

            var sepet = db.Carts.Count();
            ViewBag.sepet = sepet;

            var user = db.Users.Count();
            ViewBag.kullanici = user;

            return View();
        }
    }
}