using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public void Add(NewsLetter p)
        {
            _newsLetterDAL.Insert(p);
        }
    }
}
