using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using technologyMarket.DataAccessLayer.Context;
using technologyMarket.EntityLayer.Entitites;

namespace technologyMarket.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        DataContext db = new DataContext();
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Login(User data)
        {
            var informations = db.Users.FirstOrDefault(x => x.Email == data.Email && x.Password == data.Password);
            if (informations!=null){
                FormsAuthentication.SetAuthCookie(informations.Email, false);
                Session["Mail"] = informations.Email.ToString();
                Session["Name"] = informations.Name.ToString();
                Session["Surname"] = informations.Surname.ToString();
                Session["userid"] = informations.Id.ToString();
                return RedirectToAction("Index", "Home");
            }
            ViewBag.hata = "Your e-mail or password incorrect";
            return View(data);
        }

        [HttpPost]
        public ActionResult Register(User data)
        {
            if (ModelState.IsValid)
            {             
                db.Users.Add(data);
                data.Role = "User";
                db.SaveChanges();
                return RedirectToAction("Login");
            }
            ModelState.AddModelError("", "Error");
            return View("Login", data);
        }

        [HttpGet]
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}