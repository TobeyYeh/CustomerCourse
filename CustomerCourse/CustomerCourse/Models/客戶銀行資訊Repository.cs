using System;
using System.Linq;
using System.Collections.Generic;

namespace CustomerCourse.Models
{
    public class 客戶銀行資訊Repository : EFRepository<客戶銀行資訊>, I客戶銀行資訊Repository
    {
        public IQueryable<客戶銀行資訊> getCustBankList()
        {
            return this.All().Where(p => p.IsDeleted == false);
        }

        public 客戶銀行資訊 Find(int id)
        {
            return this.All().FirstOrDefault(p => p.Id == id);
        }

        public override void Add(客戶銀行資訊 entity)
        {
            base.Add(entity);
            this.UnitOfWork.Commit();
        }

      

        public override void Delete(客戶銀行資訊 entity)
        {
            entity.IsDeleted = true;
            this.UnitOfWork.Commit();
        }
    }

    public interface I客戶銀行資訊Repository : IRepository<客戶銀行資訊>
    {

    }
}