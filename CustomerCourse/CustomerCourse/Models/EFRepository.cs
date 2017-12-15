using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;

namespace CustomerCourse.Models
{
    public class EFRepository<T> : IRepository<T> where T : class
    {
        public IUnitOfWork UnitOfWork { get; set; }

        private IDbSet<T> _objectset;
        private IDbSet<T> ObjectSet
        {
            get
            {
                if (_objectset == null)
                {
                    _objectset = UnitOfWork.Context.Set<T>();
                }
                return _objectset;
            }
        }

        public virtual IQueryable<T> All()
        {
            return ObjectSet.AsQueryable();
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            return ObjectSet.Where(expression);
        }

        public virtual void Add(T entity)
        {
            ObjectSet.Add(entity);
        }

        public virtual void Update(T entity)
        {

            if (UnitOfWork.Context.Entry(entity).State == EntityState.Detached)
            {
                HandleDetached(entity);
            }


            ObjectSet.Attach(entity);
            UnitOfWork.Context.Entry(entity).State = EntityState.Modified;

        }

      

        public virtual void Delete(T entity)
        {
            ObjectSet.Remove(entity);
        }

    }
}