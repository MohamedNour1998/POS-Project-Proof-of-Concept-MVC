using Microsoft.EntityFrameworkCore;
using MoDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoDemo.Reprository
{
    public class DepartmentRep:IDepartmentRep
    {
        ITIEntity context;
        public DepartmentRep(ITIEntity db)
        {
            context = db;
        }
        public IEnumerable<Department> GetAll()
        {
            var data = context.Departments.ToList();
            return data;
        }
        public IEnumerable<Department> GetAllwithemployeeName()
        {
            return context.Departments.Include(a => a.Employees).ToList();
        }
        public Department GetById(int id)
        {
            var data = context.Departments.FirstOrDefault(e => e.Id == id);
            return data;
        }
        public void Inseart(Department Dept)
        {
            context.Departments.Add(Dept);
            context.SaveChanges();
        }
        public void Edit(Department Dept)
        {
            var olddata = context.Departments.FirstOrDefault(e => e.Id == Dept.Id);
            olddata.Name = Dept.Name;
            olddata.ManagerName = Dept.ManagerName;
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            var data = GetById(id);
            context.Departments.Remove(data);
            context.SaveChanges();
        }
    }
}
