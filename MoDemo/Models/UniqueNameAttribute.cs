using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoDemo.Models
{
    public class UniqueNameAttribute :ValidationAttribute
    {
        //using custom validation server side only
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null) 
            {
                string name = value.ToString(); //the value of attribute
                ITIEntity context = new ITIEntity();
                Employee emp = context.Employees.FirstOrDefault(e => e.Name == name);
                if (emp == null)
                {
                    return ValidationResult.Success;
                }

                return new ValidationResult("name already found");//error message
            }

            return new ValidationResult("name required");//error message
        }
    }
}
