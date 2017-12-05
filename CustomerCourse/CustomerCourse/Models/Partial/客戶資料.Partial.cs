using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomerCourse.Models.Partial
{

    [MetadataType(typeof(客戶資料MetaData))]
    public partial class 客戶資料
    {
    }
    public partial class 客戶資料MetaData
    {
        public int Id { get; set; }
        [StringLength(10, ErrorMessage = "欄位長度不得大於 10個字元")]
        public string 客戶名稱 { get; set; }
        [Required]
        public string 統一編號 { get; set; }
        [Required]
        public string 電話 { get; set; }
        [Required]
        public string 傳真 { get; set; }
        [StringLength(40, ErrorMessage = "欄位長度不得大於 40 個字元")]
        public string 地址 { get; set; }
        [Required]
        public string Email { get; set; }

        public virtual ICollection<客戶銀行資訊> 客戶銀行資訊 { get; set; }

        public virtual ICollection<客戶聯絡人> 客戶聯絡人 { get; set; }
    }
}