using System;
using System.ComponentModel.DataAnnotations;
using UserSignup.Models;

namespace UserSignup.ViewModels
{
    public class AddUserViewModel
    {
        [Required]
        public string Username { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage ="Password is not long enough")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Verify Password")]
        [Compare("Password", ErrorMessage ="Passwords do not match")]
        public string Verify { get; set; }

        public AddUserViewModel()
        {
            //default constructor
        }

       
    }
}
