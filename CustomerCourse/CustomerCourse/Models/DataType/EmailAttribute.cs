using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomerCourse.Models.DataType
{
    public class EmailAttribute : DataTypeAttribute
    {
        public EmailAttribute() : base(System.ComponentModel.DataAnnotations.DataType.Text)
        {

        }
        public override bool IsValid(object value)
        {
            return base.IsValid(value);
        }

    }
}


