using System;
using System.Linq;
using System.Collections.Generic;

namespace CustomerCourse.Models
{
    public class 客戶聯絡人Repository : EFRepository<客戶聯絡人>, I客戶聯絡人Repository
    {
        public IQueryable<客戶聯絡人> get客戶聯絡人清單()
        {
            return this.All().Where(p => p.IsDeleted == false);
        }

        public IQueryable<客戶聯絡人> get客戶聯絡人清單(客戶聯絡人 entity)
        {
            return this.All().Where(p => p.Email == entity.Email);
        }

        public override void Add(客戶聯絡人 entity)
        {
            base.Add(entity);
        }

        public override void Update(客戶聯絡人 entity)
        {
            base.Update(entity);
        }

        public override void Delete(客戶聯絡人 entity)
        {
            base.Delete(entity);
        }







    }

    public interface I客戶聯絡人Repository : IRepository<客戶聯絡人>
    {

    }
}