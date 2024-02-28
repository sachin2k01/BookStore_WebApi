using BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelLayer.Models;
using RepositoryLayer.Entities;

namespace BookStore_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserBusiness _iuserBusiness;
        public UserController( IUserBusiness iuserBusiness)
        {
            _iuserBusiness = iuserBusiness;
        }

        [HttpPost]
        [Route("register")]
        public IActionResult userRegister(userRegisterModel userModel)
        {
            var registerUser=_iuserBusiness.RegisterUser(userModel);
            if (registerUser != null)
            {
                return Ok(new ResponseModel<userRegisterModel> { Success = true, Message = "Register Successfull", Data = registerUser });
            }
            else
            {
                return BadRequest(new ResponseModel<userRegisterModel> { Success = false, Message = "User Register Failed" });
            }
        }

        [HttpPost]
        [Route("login")]
        public IActionResult userLogin(userLoginModel userLogin)
        {
            string loginUser = _iuserBusiness.LoginUser(userLogin);
            if(loginUser != null)
            {
                return Ok(new ResponseModel<string> { Success = true, Message = "Login Successfull", Data = loginUser });
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
