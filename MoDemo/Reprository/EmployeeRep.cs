using MoDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoDemo.Reprository
{
    public class EmployeeRep :IEmployeeRep
    {
        ITIEntity context;
        public EmployeeRep(ITIEntity db)
        {
            context = db;
        }
        public IEnumerable<Employee> GetAll()
        {
            var data = context.Employees.ToList();
            return data;
        }
        public Employee GetById(int id)
        {
            var data = context.Employees.FirstOrDefault(e=>e.Id==id);
            return data;
        }
        public IEnumerable<Employee> GetByEmpid( int deptId)
        {
          return context.Employees.Where(e => e.Dept_Id == deptId).ToList();
        }
        public void Inseart(Employee emp)
        {
            context.Employees.Add(emp);
            context.SaveChanges();
        }
        public void Edit(Employee Emp)
        {
            var olddata = context.Employees.FirstOrDefault(e=>e.Id==Emp.Id);
            olddata.Name = Emp.Name;
            olddata.Address = Emp.Address;
            olddata.Image = Emp.Image;
            olddata.Salary = Emp.Salary;
            olddata.Dept_Id = Emp.Dept_Id;
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            var data = GetById(id);
            context.Employees.Remove(data);
            context.SaveChanges();
        }
    }
}
