using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using technologyMarket.EntityLayer.Entitites;

namespace technologyMarket.DataAccessLayer.Context
{
    public class DataContext:DbContext
    {
        public DbSet<Cart> Carts{ get; set; }
        public  DbSet<Product>Products { get; set; }
        public  DbSet<Category>Categories { get; set; }
        public  DbSet<Sales>Sales { get; set; }
        public  DbSet<User>Users{ get; set; }
        public  DbSet<Comment>Comments{ get; set; }
    }
}
