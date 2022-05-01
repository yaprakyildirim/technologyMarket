using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace technologyMarket.EntityLayer.Entitites
{
    public class Comment
    {
        public int Id { get; set; }
        [DisplayName ("Comment")]
        public string Contents { get; set; }
        [DisplayName("Product")]
        public int ProductId{ get; set; }
        public virtual Product Product { get; set; }

        [DisplayName("User")]
        public int UserId { get; set; }

        public virtual User User { get; set; }

        public DateTime Date { get; set; }
    }
}
