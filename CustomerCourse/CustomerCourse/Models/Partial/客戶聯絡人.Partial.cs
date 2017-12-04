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
        public string 客戶名稱 { get; set; }
        public string 統一編號 { get; set; }
        public string 電話 { get; set; }
        public string 傳真 { get; set; }
        public string 地址 { get; set; }
        public string Email { get; set; }

        public virtual ICollection<客戶銀行資訊> 客戶銀行資訊 { get; set; }

        public virtual ICollection<客戶聯絡人> 客戶聯絡人 { get; set; }
    }
}