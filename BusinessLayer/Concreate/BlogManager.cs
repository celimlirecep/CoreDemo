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
    public class BlogManager : IBlogService
    {
        private IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void Add(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void Delete(Blog blog)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetBlogListByWriter(int id)
        {
            return _blogDal.GetListByFunc(i => i.BlogID == id);
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }

        public Blog GetByFunc(Expression<Func<Blog, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Blog GetById(int id)
        {
            return _blogDal.GetById(id);
        }

        public List<Blog> GetListAll()
        {
            return _blogDal.GetListAll();
        }
        public List<Blog> GetLast3Blog()
        {
          return  _blogDal.GetListAll().Take(3).ToList();
        }

        public List<Blog> GetListByFunc(Expression<Func<Blog, bool>> filter)
        {
            return _blogDal.GetListByFunc(filter);
        }

        public void Update(Blog blog)
        {
            throw new NotImplementedException();
        }
    }
}
