using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using technologyMarket.BusinessLayer.Concrete;

namespace technologyMarket.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryRepository categoryRepository = new CategoryRepository();
        public PartialViewResult CategoryList()
        {
            return PartialView(categoryRepository.List());
        }
        
        
        public ActionResult Details(int id)
        {
            var cat = categoryRepository.CategoryDetails(id);
            return View(cat);
        }
    }
}