using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MoDemo.Models;
using MoDemo.Reprository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoDemo.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IDepartmentRep deptRep;
        private readonly IEmployeeRep empRep;

        public EmployeeController(IDepartmentRep DeptRep, IEmployeeRep EmpRep)
        {
            deptRep = DeptRep;
            empRep = EmpRep;
        }
        [Authorize]
        public IActionResult Index()
        {
            return View(empRep.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewData["DeptList"] = deptRep.GetAll();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]//for privent hacking from hackers  call internal 
        public IActionResult Create(Employee NewEmployee)
        {
            if (ModelState.IsValid) //validation for server side
            {
                try
                {
                    empRep.Inseart(NewEmployee);
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    //error to client view custom error
                    ModelState.AddModelError(string.Empty, ex.Message.ToString());
                }

            }
            ViewData["DeptList"] =deptRep.GetAll();
            return View("Create", NewEmployee);
        }
        public IActionResult Edit(int id)
        {
            Employee empmodel = empRep.GetById(id);
            ViewData["Deptlist"] = deptRep.GetAll();
            return View(empmodel);
        }

        [HttpPost]
        public IActionResult SaveEdit(Employee newEmp)
        {
            if (ModelState.IsValid)
            {
                empRep.Edit(newEmp);
                return RedirectToAction("Index");
            }
            ViewData["Deptlist"] = deptRep.GetAll();
            return RedirectToAction("Edit");
        }

        public IActionResult Details( int id)
        {
            return View(empRep.GetById(id));
        }

        public IActionResult DetailsUsingPartial(int id)
        {
            Employee emp = empRep.GetById(id);
            return PartialView("_EmployeeCardPartial", emp); //without layout
        }
        //using for custom validation using remote(Build in validation) can also support clientside validation
        public IActionResult CheckSalary(int Salary)
        {
            if (Salary>=2000)
            {
                return Json(true);
            }
            return Json(false);
        }
    }
}
