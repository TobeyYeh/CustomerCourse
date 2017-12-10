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


        public override void Add(客戶資料 entity)
        {
            base.Add(entity);
        }

        public override void Delete(客戶資料 entity)
        {
            base.Delete(entity);
        }

    }




    public interface I客戶資料Repository : IRepository<客戶資料>
    {

    }
}