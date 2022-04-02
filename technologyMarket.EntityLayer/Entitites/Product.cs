using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace technologyMarket.EntityLayer.Entitites
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "You cannot leave the required field blank.")]
        [Display(Name = "Description")]
        [StringLength(50, ErrorMessage = "Must be a maximum of 50 characters.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "You cannot leave the required field blank.")]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "You cannot leave the required field blank.")]
        [Display(Name = "Stock")]
        public int Stock { get; set; }

        [Required(ErrorMessage = "You cannot leave the required field blank.")]
        [Display(Name = "Popular")]
        public bool Popular { get; set; }

        [Required(ErrorMessage = "You cannot leave the required field blank.")]
        [Display(Name = "Approved")]
        public bool IsApproved { get; set; }

        [Required(ErrorMessage = "You cannot leave the required field blank.")]
        [Display(Name = "Image")]
        public string Image { get; set; }

        [Required(ErrorMessage = "You cannot leave the required field blank.")]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "You cannot leave the required field blank.")]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        //Category tablosuyla ilişki kurduk
        public virtual Category Category { get; set; }
    }
}
