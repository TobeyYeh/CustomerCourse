using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace CustomerCourse.Models.DataType
{
    public class PhoneAttribute : ValidationAttribute
    { 
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return true;
            }

            if (Regex.IsMatch(value.ToString(), @"\d{4}-\d{6}"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}