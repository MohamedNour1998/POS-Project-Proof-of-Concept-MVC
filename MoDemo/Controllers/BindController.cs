using Microsoft.AspNetCore.Mvc;
using MoDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoDemo.Controllers
{
    public class BindController : Controller
    {
        //Bind/Testprimitive?name=mohamed&id=1
        public IActionResult Testprimitive(int id,string name)
        {
            return Content($"name={name} id={id}");
        }


        //Bind collection (Dictionary (key ,value))
        //Bind/TestDic?name=mohamed&phones[ahmed]=123&phones[mo]=453
        public IActionResult TestDic(Dictionary<string,int>phones, string name)
        {
            return Content($"name={name} ");
        }

        public IActionResult TestComplex (Department dept)
        {
            return Content("ok ");
        }

    }
}
