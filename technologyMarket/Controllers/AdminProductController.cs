using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using technologyMarket.BusinessLayer.Concrete;
using technologyMarket.DataAccessLayer.Context;
using technologyMarket.EntityLayer.Entitites;
using PagedList;
using PagedList.Mvc;

namespace technologyMarket.Controllers
{
    public class AdminProductController : Controller
    {
        // GET: AdminProduct

        ProductRepository productRepository = new ProductRepository();
        DataContext db = new DataContext();
        public ActionResult Index(int sayfa=1)
        {
            return View(productRepository.List().ToPagedList(sayfa,3));
        }

        public ActionResult Create()
        {
            List<SelectListItem> deger1 = (from i in db.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = i.Name,
                                               Value = i.Id.ToString()
                                           }).ToList();
            ViewBag.ktgr = deger1;
            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create(Product data,HttpPostedFileBase File)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Error");
            }

            string path = Path.Combine("~/img/" + File.FileName);
            File.SaveAs(Server.MapPath(path));
            data.Image = File.FileName.ToString();
            productRepository.Insert(data);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var delete = productRepository.GetById(id);
            productRepository.Delete(delete);
            return RedirectToAction("Index");
        }

        public ActionResult Update(int id)
        {
            List<SelectListItem> deger1 = (from i in db.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = i.Name,
                                               Value = i.Id.ToString()
                                           }).ToList();
            ViewBag.ktgr = deger1;

            var update = productRepository.GetById(id);
            return View(update);
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Update(Product data, HttpPostedFileBase File)
        {
            var update = productRepository.GetById(data.Id);
            if (!ModelState.IsValid)
            {
                if (File == null)
                {
                    update.Description = data.Description;
                    update.Name = data.Name;
                    update.IsApproved = data.IsApproved;
                    update.Popular = data.Popular;
                    update.Price = data.Price;
                    update.Stock = data.Stock;
                    update.CategoryId = data.CategoryId;
                    productRepository.Update(data);
                    return RedirectToAction("Index");
                }
                else
                {
                    update.Description = data.Description;
                    update.Name = data.Name;
                    update.IsApproved = data.IsApproved;
                    update.Popular = data.Popular;
                    update.Price = data.Price;
                    update.Stock = data.Stock;
                    update.Image = File.FileName.ToString();
                    update.CategoryId = data.CategoryId;
                    productRepository.Update(update);
                    return RedirectToAction("Index");
                }
            }
            return View(update);
        }

        public ActionResult CriticalStock()
        {
            var critic = db.Products.Where(x => x.Stock <= 50).ToList();
            return View(critic);
        }

        public PartialViewResult StockCount()
        {
            if(User.Identity.IsAuthenticated)
            {
                var count = db.Products.Where(x => x.Stock < 50).Count();
                ViewBag.count = count;
                var azalan = db.Products.Where(x => x.Stock == 50).Count();
                ViewBag.azalan = azalan;
            }
            return PartialView();
        }
    }
}