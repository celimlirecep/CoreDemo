using DataAccessLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
   public class GenericRepository<T>:IGenericDal<T> where T:class
    {
        public void Delete(T entity)
        {
            using (var context = new Context())
            {
                context.Entry(entity).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public T GetByFunc(Expression<Func<T, bool>> filter)
        {
            using (var context = new Context())
            {
                return context.Set<T>().FirstOrDefault(filter);
            }
        }

        public T GetById(int id)
        {
            using (var context = new Context())
            {
                return context.Set<T>().Find(id);
            }
        }

        public List<T> GetListAll()
        {
            using (var context = new Context())
            {
                return context.Set<T>().ToList();
            }
        }

        public List<T> GetListByFunc(Expression<Func<T, bool>> filter)
        {
            using (var context = new Context())
            {
                return context.Set<T>().Where(filter).ToList();
            }
        }

        public void Insert(T entity)
        {
            using (var context = new Context())
            {
                context.Entry(entity).State = EntityState.Added;
                context.SaveChanges();
            };
        }

        public void Update(T entity)
        {
            using (var context = new Context())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
