using BusinessLayer.Interfaces;
using BusinessLayer.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelLayer.Models;

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

        [Authorize]
        [HttpPost]
        [Route("address")]
        public IActionResult addUserAddress(userAddressModel address)
        {
            int userId = int.Parse(User.Claims.Where(x => x.Type == "UserId").FirstOrDefault().Value);
            if(userId == 0)
            {
                return NotFound();
            }
            var userAddress=_userAddressBusiness.addUserAddress(address,userId);
            if(userAddress != null)
            {
                return Ok(userAddress);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
