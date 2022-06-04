using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDeneme.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="Please Enter Username")]
        public string username { get; set; }
        [Required(ErrorMessage = "Please Enter Password")]
        public string password { get; set; }
    }
}
