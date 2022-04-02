using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace technologyMarket.EntityLayer.Entitites
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "You cannot leave the required field blank.")]
        [Display(Name = "Name")]
        [StringLength(50, ErrorMessage = "Must be a maximum of 50 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "You cannot leave the required field blank.")]
        [Display(Name = "Surname")]
        [StringLength(50, ErrorMessage = "Must be a maximum of 50 characters.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "You cannot leave the required field blank.")]
        [Display(Name = "Email")]
        [StringLength(50, ErrorMessage = "Must be a maximum of 50 characters.")]
        [EmailAddress(ErrorMessage ="Must be a E-mail format.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "You cannot leave the required field blank.")]
        [Display(Name = "Username")]
        [StringLength(50, ErrorMessage = "Must be a maximum of 50 characters.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "You cannot leave the required field blank.")]
        [Display(Name = "Password")]
        [StringLength(10, ErrorMessage = "Must be a maximum of 10 characters.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "You cannot leave the required field blank.")]
        [Display(Name = "RePassword")]
        [StringLength(10, ErrorMessage = "Must be a maximum of 10 characters.")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Passwords do not match!")]
        public string RePassword { get; set; }

        [StringLength(10, ErrorMessage = "Must be a maximum of 10 characters.")]
        public string Role { get; set; }
    }
}
