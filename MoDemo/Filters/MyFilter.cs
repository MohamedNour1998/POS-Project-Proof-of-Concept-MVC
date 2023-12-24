using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoDemo.Filters
{
    public class MyFilter : Attribute, IActionFilter
    {
        // after execute Action
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("OnActionExecuted");
        }

        // During execute Action
        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("OnActionExecuting");
        }
    }
}
