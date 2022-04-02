using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace technologyMarket.EntityLayer.Entitites
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "You cannot leave the required field blank.")]
        [Display(Name = "Name")]
        [StringLength(50, ErrorMessage = "Must be a maximum of 50 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "You cannot leave the required field blank.")]
        [Display(Name = "Description")]
        [StringLength(150, ErrorMessage = "Must be a maximum of 150 characters.")]
        public string Description { get; set; }

        //Bir kategoride birden fazla ürün alabilir
        public virtual List<Product> Products {get; set;}
    }
}
