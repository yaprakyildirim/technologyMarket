using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using technologyMarket.DataAccessLayer.Context;
using technologyMarket.EntityLayer.Entitites;

namespace technologyMarket.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        DataContext db = new DataContext();
        public ActionResult Update()
        {
            var username = (string)Session["Mail"];
            var degerler = db.Users.FirstOrDefault(x => x.Email == username);
            return View(degerler);
        }
        [HttpPost]
        public ActionResult Update(User data)
        {
            var username = (string)Session["Mail"];
            var user = db.Users.Where(x => x.Email == username).FirstOrDefault();
            user.Name = data.Name;
            user.Surname = data.Surname;
            user.Email = data.Email;
            user.Password = data.Password;
            user.RePassword = data.RePassword;
            user.Username = data.Username;
            db.SaveChanges();
            return RedirectToAction("Index", "Home");

        }
    }
}