using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace CustomerCourse.Models.DataType
{
    public partial class PhoneAttribute : DataTypeAttribute
    {
        public PhoneAttribute() : base(System.ComponentModel.DataAnnotations.DataType.Text)
        {

        }

        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return true;
            }

            if (value is String)
            {
                return Regex.IsMatch(value.ToString(), @"\d{4}-\d{6}");
            }
            else
            {
                return true;
            }
        }
    }
}