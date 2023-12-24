using Microsoft.AspNetCore.Mvc;
using MoDemo.Models;
using MoDemo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoDemo.Controllers
{
    public class PassDataController : Controller
    {
        ITIEntity context = new ITIEntity();
        public IActionResult TestViewData(int id)
        {
            Employee empmodel = context.Employees.FirstOrDefault(a=>a.Id==id);

            string msg = "hello";
            List<string> branches = new List<string>();
            branches.Add("minia");
            branches.Add("Alex");
            branches.Add("Cairo");
            int temp = 44;
            ViewData["Message"]=msg;
            ViewData["bran"] = branches;
            ViewBag.Message = branches;
            ViewData["tem"] = temp;
            return View(empmodel);
        }

        public IActionResult TestViewModel(int id)
        {

            Employee empmodel = context.Employees.FirstOrDefault(a => a.Id == id);

            string msg = "hello";
            List<string> branches = new List<string>();
            branches.Add("minia");
            branches.Add("Alex");
            branches.Add("Cairo");
            int temp = 44;
            EmployeeWithMessageAndBranchlistVM EmpVM = new EmployeeWithMessageAndBranchlistVM();

            EmpVM.Message = msg;
            EmpVM.temp = temp;
            EmpVM.branch = branches;
            EmpVM.EmpName = empmodel.Name;
            EmpVM.EmpId = empmodel.Id;
            return View(EmpVM);
        }
    }
}
