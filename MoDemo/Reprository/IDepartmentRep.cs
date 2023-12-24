using MoDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoDemo.Reprository
{
  public interface IDepartmentRep
    {
        IEnumerable<Department> GetAll();     
        IEnumerable<Department> GetAllwithemployeeName();
         Department GetById(int id);      
         void Inseart(Department Dept);
         void Edit(Department Dept);
         void Delete(int id);
       
    }
}
