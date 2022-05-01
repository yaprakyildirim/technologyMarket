using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using technologyMarket.BusinessLayer.Abstract;
using technologyMarket.DataAccessLayer.Context;
using technologyMarket.EntityLayer.Entitites;

namespace technologyMarket.BusinessLayer.Concrete
{
    public class CategoryRepository:GenericRepository<Category>
    {
        DataContext db = new DataContext();
        public List<Product>CategoryDetails(int id)
        {
            return db.Products.Where(x => x.CategoryId == id).ToList();
        }
    }
}
