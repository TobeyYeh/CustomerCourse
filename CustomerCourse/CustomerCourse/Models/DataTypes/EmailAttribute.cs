using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomerCourse.Models.DataType
{
    public class EmailAttribute : DataTypeAttribute
    {
        protected 客戶聯絡人Repository CustContactRepo = RepositoryHelper.Get客戶聯絡人Repository();

        public EmailAttribute() : base(System.ComponentModel.DataAnnotations.DataType.Text)
        {

        }
        public override bool IsValid(object value)
        {

            return base.IsValid(value);
        }

      

    }
}


