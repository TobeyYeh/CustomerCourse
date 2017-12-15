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

        public 客戶聯絡人 Find(int id)
        {
            return this.All().FirstOrDefault(p => p.Id == id);
        }

        public 客戶聯絡人 Email不重複(string Email)
        {
            return this.All().FirstOrDefault(p => p.Email == Email);
        }

        public override void Add(客戶聯絡人 entity)
        {
            base.Add(entity);
            this.UnitOfWork.Commit();
        }



        public override void Delete(客戶聯絡人 entity)
        {
            base.Delete(entity);
            this.UnitOfWork.Commit();
        }







    }

    public interface I客戶聯絡人Repository : IRepository<客戶聯絡人>
    {

    }
}