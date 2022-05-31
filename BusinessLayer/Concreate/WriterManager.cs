using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class WriterManager : IWriterService
    {
         private IWriterDAL _writerDAL;

        public WriterManager(IWriterDAL writerDAL)
        {
            _writerDAL = writerDAL;
        }

        public void Add(Writer comment)
        {
            _writerDAL.Insert(comment);
        }

        public void Delete(Writer comment)
        {
            _writerDAL.Delete(comment);
        }

        public Writer GetByFunc(Expression<Func<Writer, bool>> filter)
        {
            return _writerDAL.GetByFunc(filter);
        }

        public Writer GetById(int id)
        {
            return _writerDAL.GetById(id);
        }

        public List<Writer> GetListAll()
        {
            return _writerDAL.GetListAll();
        }

        public List<Writer> GetListByFunc(Expression<Func<Writer, bool>> filter)
        {
            return _writerDAL.GetListByFunc(filter);
        }

        public void Update(Writer comment)
        {
            _writerDAL.Update(comment);
        }
    }
}
