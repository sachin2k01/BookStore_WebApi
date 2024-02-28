using ModelLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IUserAddressBusiness
    {
        public userAddressModel addUserAddress(userAddressModel userAddress,int userId);
    }
}
