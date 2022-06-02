using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDeneme.Models
{
    public class UserSignUpViewModel
    {
        [Display(Name = "Name Surname")]
        [Required(ErrorMessage = "Please Enter Name and Surname")]
        public string nameSurname { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please Enter Password")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Wrong Password")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Mail Address")]
        [Required(ErrorMessage = "Please Enter Mail")]
        public string Mail { get; set; }

        [Display(Name = "UserName")]
        [Required(ErrorMessage = "Please Enter Username")]
        public string UserName { get; set; }
        
    }
}