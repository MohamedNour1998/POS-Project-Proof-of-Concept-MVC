using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoDemo.Controllers
{
    public class StateManagementController : Controller
    {
        #region Cookies

        public IActionResult SetCookies()
        {
            CookieOptions cookieOptions = new CookieOptions();
            cookieOptions.Expires = DateTimeOffset.Now.AddHours(2);
            Response.Cookies.Append("name","Mohamed",cookieOptions);//presetent cookies
            Response.Cookies.Append("age","12");//session cookies 20 min
            return Content("Data Saved");
        }

        public IActionResult getCookies()
        {
          string name=  Request.Cookies["name"];
          int age= int.Parse( Request.Cookies["age"]);
            return Content($"name ={name} age={age}");
        }

        #endregion
        #region Session

        public IActionResult SetSession()
        {
            HttpContext.Session.SetString("name","mohamed");
            HttpContext.Session.SetInt32("age", 25);
            return Content("Data Saved");
        }

        public IActionResult GetSession()
        {
            string name=HttpContext.Session.GetString("name");
            int age=HttpContext.Session.GetInt32("age").Value;
            return Content($"name={name}  age={age}");
        }


        #endregion
        #region TempData
        public IActionResult SetTempData()
        {
            TempData["Message"] = "Hello TempData";
            return Content("DataSaved");
        }

        public IActionResult get1()
        {
            string msg = "Empty";
                if (TempData.ContainsKey("Message"))
            {
                //msg = TempData["Message"].ToString();//normal read
               
                msg = TempData.Peek("Message").ToString();//with out delete tempdata from cookies
            }
            
            return Content("get1" +msg);
        }

        public IActionResult get2()
        {
            string msg = TempData["Message"].ToString();
            TempData.Keep("Message");//using after normal for with out delete tempdata from cookies
            return Content("get2"+msg);
        }
        #endregion
    }
}
