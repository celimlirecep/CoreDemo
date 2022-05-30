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
    public class CommentManager : ICommentService
    {
        private ICommentDAL _commentDAL;

        public CommentManager(ICommentDAL commentDAL)
        {
            _commentDAL = commentDAL;
        }

        public void Add(Comment comment)
        {
            _commentDAL.Insert(comment);
        }

        public void Delete(Comment comment)
        {
            throw new NotImplementedException();
        }

        public Comment GetByFunc(Expression<Func<Comment, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Comment GetById(int id)
        {
            return _commentDAL.GetById(id);
        }

        public List<Comment> GetListAll()
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetListByFunc(Expression<Func<Comment, bool>> filter)
        {
            return _commentDAL.GetListByFunc(filter);
        }

        public void Update(Comment comment)
        {
            throw new NotImplementedException();
        }
    }
}
