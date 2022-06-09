using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDeneme.Areas.Admin.Models
{
    public class RoleViewModel
    {
        [Required(ErrorMessage ="Please Write Role Name")]
        public string name { get; set; }
    }
}
