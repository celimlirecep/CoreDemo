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
    public class ContactManager : IContactService
    {
        private IContactDAL _contactDAL;

        public ContactManager(IContactDAL contactDAL)
        {
            _contactDAL = contactDAL;
        }

        public void Add(Contact comment)
        {
            _contactDAL.Insert(comment);
        }

        public void Delete(Contact comment)
        {
            _contactDAL.Delete(comment);
        }

        public Contact GetByFunc(Expression<Func<Contact, bool>> filter)
        {
            return _contactDAL.GetByFunc(filter);
        }

        public Contact GetById(int id)
        {
            return _contactDAL.GetById(id);
        }

        public List<Contact> GetListAll()
        {
            return _contactDAL.GetListAll();
        }

        public List<Contact> GetListByFunc(Expression<Func<Contact, bool>> filter)
        {
            return _contactDAL.GetListByFunc(filter);
        }

        public void Update(Contact comment)
        {
            _contactDAL.Update(comment);
        }
    }
}
