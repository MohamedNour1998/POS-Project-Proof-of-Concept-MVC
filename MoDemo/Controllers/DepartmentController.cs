using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoDemo.Models;
using MoDemo.Reprository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoDemo.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRep deptRep;
        private readonly IEmployeeRep empRep;

        public DepartmentController(IDepartmentRep DeptRep, IEmployeeRep EmpRep)
        {
            deptRep = DeptRep;
            empRep = EmpRep;
        }
        public IActionResult Index()
        {

            IEnumerable<Department> Deptlist = deptRep.GetAllwithemployeeName();
            return View(Deptlist);
        }

        public IActionResult showDepartmentEmployee()
        {
            IEnumerable<Department> Deptlist = deptRep.GetAll();
            return View(Deptlist);
        }

        public IActionResult GetEmployeeByDept(int deptId)
        {
            IEnumerable<Employee> emps = empRep.GetByEmpid(deptId);
            return Json(emps);
        }

        [HttpGet]
        public IActionResult New()
        {
            return View(new Department());//هنا عطناله اوبجكت فاضى ععلشان الصفحة بخليها لما تروح وترجع بالبيانات
        }

        [HttpPost]
        public IActionResult SaveNew(Department dept)
        {
            if (dept.Name!=null)
            {
                deptRep.Inseart(dept);
                return RedirectToAction("Index");
            }
            return View("New",dept);
        }
    }
}
 