using ModelLayer.Models;
using RepositoryLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IUserBusiness
    {
        public userRegisterModel RegisterUser(userRegisterModel model);
        public userEntity LoginUser(userLoginModel loginModel);
    }
}
