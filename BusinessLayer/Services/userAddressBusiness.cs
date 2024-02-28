using BusinessLayer.Interfaces;
using RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class userAddressBusiness:IUserAddressBusiness
    {
        private readonly IUserAddressRepo _iuserAddressRepo;
        public userAddressBusiness(IUserAddressRepo iuserAddressRepo)
        {
            _iuserAddressRepo = iuserAddressRepo;
        }
    }
}
