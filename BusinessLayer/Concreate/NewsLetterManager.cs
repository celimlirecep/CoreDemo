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
    public class NewsLetterManager : INewsLetterService
    {
        private INewsLetterDAL _newsLetterDAL;

        public NewsLetterManager(INewsLetterDAL newsLetterDAL)
        {
            _newsLetterDAL = newsLetterDAL;
        }

        public void Add(NewsLetter comment)
        {
            _newsLetterDAL.Insert(comment);
        }

        public void Delete(NewsLetter comment)
        {
            _newsLetterDAL.Delete(comment);
        }

        public NewsLetter GetByFunc(Expression<Func<NewsLetter, bool>> filter)
        {
            return _newsLetterDAL.GetByFunc(filter);
        }

        public NewsLetter GetById(int id)
        {
            return _newsLetterDAL.GetById(id);
        }

        public List<NewsLetter> GetListAll()
        {
            return _newsLetterDAL.GetListAll();
        }

        public List<NewsLetter> GetListByFunc(Expression<Func<NewsLetter, bool>> filter)
        {
            return _newsLetterDAL.GetListByFunc(filter);
        }

        public void Update(NewsLetter comment)
        {
            _newsLetterDAL.Update(comment);
        }
    }
}
