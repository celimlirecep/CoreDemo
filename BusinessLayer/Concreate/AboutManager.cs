using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class AboutManager : IAboutService
    {
        private IAboutDAL _aboutDAL;

        public AboutManager(IAboutDAL aboutDAL)
        {
            _aboutDAL = aboutDAL;
        }

        public void Add(About category)
        {
            _aboutDAL.Insert(category);
        }

        public void Delete(About category)
        {
            _aboutDAL.Delete(category);
        }

        public void Update(About category)
        {
            _aboutDAL.Update(category);
        }

        public About GetByFunc(Expression<Func<About, bool>> filter)
        {
            return _aboutDAL.GetByFunc(filter);
        }

        public About GetById(int id)
        {
            return _aboutDAL.GetById(id);
        }

        public List<About> GetListAll()
        {
            return _aboutDAL.GetListAll();
        }

        public List<About> GetListByFunc(Expression<Func<About, bool>> filter)
        {
            return _aboutDAL.GetListByFunc(filter);
        }

    }
}
