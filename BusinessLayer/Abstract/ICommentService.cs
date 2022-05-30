using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        void Add(Comment comment);
        void Delete(Comment comment);
        void Update(Comment comment);
        List<Comment> GetListAll();
        Comment GetById(int id);
        List<Comment> GetListByFunc(Expression<Func<Comment, bool>> filter);
        Comment GetByFunc(Expression<Func<Comment, bool>> filter);
    }
}
