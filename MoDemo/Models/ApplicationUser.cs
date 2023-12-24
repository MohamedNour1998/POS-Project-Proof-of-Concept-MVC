using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoDemo.Models
{
    public class ApplicationUser :IdentityUser
    {
        public string Adress { get; set; }
    }
}
