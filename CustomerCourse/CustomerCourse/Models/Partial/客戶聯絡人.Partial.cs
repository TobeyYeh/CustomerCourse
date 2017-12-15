using CustomerCourse.Models.DataType;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomerCourse.Models
{
    [MetadataType(typeof(客戶聯絡人MetaData))]
    public partial class 客戶聯絡人 : IValidatableObject
    {
        protected 客戶聯絡人Repository CustContactRepo = RepositoryHelper.Get客戶聯絡人Repository();
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var data = CustContactRepo.Email不重複(this.Email);
            if (this.Id == 0)
            {
                yield return new ValidationResult("ID無值", new string[] { "ID" });

                if (data == null)
                {
                    yield return new ValidationResult("Email已存在", new string[] { "Email" });
                }
            }
            else
            {
                if (data != null)
                {
                    yield return new ValidationResult("Email已存在", new string[] { "Email" });
                }
            }

        }

    }
    public partial class 客戶聯絡人MetaData
    {
        public int Id { get; set; }
        public int 客戶Id { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "欄位長度不得大於 50個字元")]
        public string 職稱 { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "欄位長度不得大於 50個字元")]
        public string 姓名 { get; set; }
        [Required]
        [StringLength(250, ErrorMessage = "欄位長度不得大於 250個字元")]
        public string Email { get; set; }
        [Required]
        [MobilePhoneAttribute(ErrorMessage = "手機驗證失敗")]
        public string 手機 { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "欄位長度不得大於 50個字元")]
        public string 電話 { get; set; }

        public Nullable<bool> IsDeleted { get; set; }

        public virtual 客戶資料 客戶資料 { get; set; }


    }
}