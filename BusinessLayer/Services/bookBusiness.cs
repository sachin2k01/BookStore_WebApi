using BusinessLayer.Interfaces;
using RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class bookBusiness : IBookBusiness
    {
        private readonly IUserBookRepo _iuserBook;
        public bookBusiness(IUserBookRepo iuserBook)
        {
            _iuserBook = iuserBook;
        }
    }
}
