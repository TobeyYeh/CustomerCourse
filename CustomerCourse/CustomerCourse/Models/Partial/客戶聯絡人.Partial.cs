using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomerCourse.Models.Partial
{
    [MetadataType(typeof(客戶聯絡人MetaData))]
    public partial class 客戶聯絡人
    {

    }

    public partial class 客戶聯絡人MetaData
    {
        public int Id { get; set; }
        [Required]
        public int 客戶Id { get; set; }
        [StringLength(50, ErrorMessage = "欄位長度不得大於 50個字元")]
        public string 職稱 { get; set; }
        [StringLength(50, ErrorMessage = "欄位長度不得大於 50個字元")]
        public string 姓名 { get; set; }
        public string Email { get; set; }
        public string 手機 { get; set; }
        public string 電話 { get; set; }

        public virtual 客戶資料 客戶資料 { get; set; }
    }

}