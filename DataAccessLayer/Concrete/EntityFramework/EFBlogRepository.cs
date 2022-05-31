using EntityLayer.Concrete;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EFBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> GetListWithCategory()
        {
            using (var context=new Context())
            {
                return context.Blogs
                    .Include(i => i.Category)
                    .ToList();
            }
          
        }

        //status is true ise döndürülür
        public List<Blog> GetListWithCategoryByWriter(int id)
        {
            using (var context=new Context())
            {
                return context.Blogs
                    .Where(i => i.WriterId == id && i.BlogStatus==true)
                    .Include(i => i.Category)
                    .ToList();
            }
        }
    }
}
