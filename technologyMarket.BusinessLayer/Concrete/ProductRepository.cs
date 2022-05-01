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
    public class ProductRepository : GenericRepository<Product>
    {
        DataContext db = new DataContext();
        public List<Product> GetPopularProduct()
        {
            return db.Products.Where(x => x.Popular == true).Take(3).ToList();
        }
    }
}