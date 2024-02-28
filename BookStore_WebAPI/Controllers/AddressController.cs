using BusinessLayer.Interfaces;
using BusinessLayer.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IUserAddressBusiness _userAddressBusiness;
        public AddressController(IUserAddressBusiness userAddressBusiness)
        {
            _userAddressBusiness = userAddressBusiness;
        }
    }
}
