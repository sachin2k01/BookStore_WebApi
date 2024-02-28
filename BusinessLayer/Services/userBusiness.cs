using BusinessLayer.Interfaces;
using ModelLayer.Models;
using RepositoryLayer.Entities;
using RepositoryLayer.Interfaces;


namespace BusinessLayer.Services
{
    public class userBusiness : IUserBusiness
    {
        private readonly IuserRepo _iuserRepo;
        public userBusiness(IuserRepo iuserRepo)
        {
            _iuserRepo = iuserRepo;
        }
        public userRegisterModel RegisterUser(userRegisterModel model)
        {
            return _iuserRepo.RegisterUser(model);
        }

        public string LoginUser(userLoginModel loginModel)
        {
            return _iuserRepo.LoginUser(loginModel);
        }
    }
}
