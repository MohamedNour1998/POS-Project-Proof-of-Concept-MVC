using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MoDemo.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [MinLength(4)]
        [MaxLength(30)]
        [UniqueName]
        public string Name { get; set; }

        [Required]
        [Range(5000, 10000)]
        [RegularExpression(@"[0-9]{4}",ErrorMessage ="the Salary must be 4 number")]
        [Remote ("CheckSalary", "Employee",ErrorMessage ="Salary must be greater than 2000")]
        public int Salary { get; set; }

        [Required]
        [RegularExpression("(Alex|minia|sohag)")]
        public string Address { get; set; }

        [RegularExpression(@"[a-z]+\.(Jpg|Png)")]
        public string Image { get; set; }

        [ForeignKey("Department")]
        public int Dept_Id { get; set; }
        public virtual Department Department { get; set; }

    }
}
