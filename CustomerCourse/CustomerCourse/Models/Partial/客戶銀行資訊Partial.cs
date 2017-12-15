using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomerCourse.Models
{
    [MetadataType(typeof(客戶銀行資訊MetaData))]
    public partial class 客戶銀行資訊
    {

    }
    public partial class 客戶銀行資訊MetaData
    {
        public int Id { get; set; }

        public int 客戶Id { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "欄位長度不得大於 50個字元")]
        public string 銀行名稱 { get; set; }
        [Required]
        [RegularExpression(@"\d{4}", ErrorMessage = "必須輸入四個數字")]
        public int 銀行代碼 { get; set; }
        [Required]
        [RegularExpression(@"\d{4}", ErrorMessage = "必須輸入四個數字")]
        public Nullable<int> 分行代碼 { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "欄位長度不得大於 50個字元")]
        public string 帳戶名稱 { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "欄位長度不得大於 50個字元")]
        public string 帳戶號碼 { get; set; }

        public virtual 客戶資料 客戶資料 { get; set; }
    }
}