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

      
        public List<Blog> GetBlogListByWriter(int id)
        {
            return _blogDal.GetListByFunc(i => i.BlogID == id);
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }

     

        public List<Blog> GetLast3Blog()
        {
          return  _blogDal.GetListAll().Take(3).ToList();
        }

        public void Add(Blog blog)
        {
            _blogDal.Insert(blog);
        }

        public void Delete(Blog category)
        {
            _blogDal.Delete(category);
        }

        public void Update(Blog category)
        {
            _blogDal.Update(category);
        }

        public Blog GetByFunc(Expression<Func<Blog, bool>> filter)
        {
            return _blogDal.GetByFunc(filter);
        }

        public Blog GetById(int id)
        {
            return _blogDal.GetById(id);
        }

        public List<Blog> GetListAll()
        {
            return _blogDal.GetListAll();
        }

        public List<Blog> GetListByFunc(Expression<Func<Blog, bool>> filter)
        {
            return _blogDal.GetListByFunc(filter);
        }

    }
}
