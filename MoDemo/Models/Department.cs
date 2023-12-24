using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoDemo.Models
{
    public class Department
    {

        public int Id { get; set; }

        [Display (Name ="Department Name")]
        //[DataType(DataType.Password)] for using editor and making the diffrent type for prop
        public string Name { get; set; }
        public string ManagerName { get; set; }
        public virtual List<Employee> Employees { get; set; }
    }
}
