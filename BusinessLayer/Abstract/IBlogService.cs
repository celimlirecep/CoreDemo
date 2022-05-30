using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService
    {
        void Add(Blog blog);
        void Delete(Blog blog);
        void Update(Blog blog);
        List<Blog> GetListAll();
        Blog GetById(int id);
        List<Blog> GetListByFunc(Expression<Func<Blog, bool>> filter);
        Blog GetByFunc(Expression<Func<Blog, bool>> filter);
        List<Blog> GetBlogListWithCategory();
        List<Blog> GetBlogListByWriter(int id);
        public List<Blog> GetLast3Blog();
    }
}
