using MoDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoDemo.Reprository
{
  public interface IEmployeeRep
    {
         IEnumerable<Employee> GetAll();
         Employee GetById(int id);
         IEnumerable<Employee> GetByEmpid(int deptId);
         void Inseart(Employee emp);
         void Edit(Employee Emp);
         void Delete(int id);
    }
}
