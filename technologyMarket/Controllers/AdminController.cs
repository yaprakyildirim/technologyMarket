using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using technologyMarket.DataAccessLayer.Context;
using PagedList;
using PagedList.Mvc;

namespace technologyMarket.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        DataContext DB = new DataContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Comment(int sayfa=1)
        {
            return View(DB.Comments.ToList().ToPagedList(sayfa,3));
        }

        public ActionResult Delete(int id)
        {
            var delete = DB.Comments.Where(x => x.Id == id).FirstOrDefault();
            DB.Comments.Remove(delete);
            DB.SaveChanges();
            return RedirectToAction("Comment");
        }
    }
}