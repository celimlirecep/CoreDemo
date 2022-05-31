using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService : IGenericService<Blog>
    {
        
       
        List<Blog> GetBlogListWithCategory();
        List<Blog> GetBlogListByWriter(int id);
        public List<Blog> GetLast3Blog();
        public List<Blog> GetListWithCategoryByWriter(int id);
    }
}
