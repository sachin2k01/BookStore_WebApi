using Microsoft.AspNetCore.Mvc;

namespace BookStore_WebAPI.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
