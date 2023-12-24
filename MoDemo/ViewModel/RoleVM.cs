using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoDemo.ViewModel
{
    public class RoleVM
    {
        [Required]
        public string Name { get; set; }
    }
}
