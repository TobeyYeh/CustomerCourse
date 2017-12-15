using System;
using System.Linq;
using System.Collections.Generic;

namespace CustomerCourse.Models
{
    public class 客戶資料Repository : EFRepository<客戶資料>, I客戶資料Repository
    {
        /// <summary>
        /// 尋找資料客戶ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public 客戶資料 Find(int id)
        {
            return this.All().FirstOrDefault(p => p.Id == id);
        }

        public IQueryable<客戶資料> OrderBy客戶分類(客戶資料 entity)
        {
            return this.All().OrderBy(p => p.客戶分類 == entity.客戶分類);
        }

        public IQueryable<客戶資料> Get取得客戶資料明細()
        {
            return this.All().Where(p => p.IsDeleted == false);
        }

        ///// <summary>
        ///// 關聯其他兩個資料表當新增自動補1
        ///// </summary>
        ///// <returns></returns>
        //public int Get客戶資料總數()
        //{
        //    int Count = this.All().Count();
        //    Count++;
        //    return Count;
        //}

        public override void Add(客戶資料 entity)
        {
            base.Add(entity);
            this.UnitOfWork.Commit();
        }

        public override void Delete(客戶資料 entity)
        {
            entity.IsDeleted = true;
            this.UnitOfWork.Commit();
        }

    }




    public interface I客戶資料Repository : IRepository<客戶資料>
    {

    }
}