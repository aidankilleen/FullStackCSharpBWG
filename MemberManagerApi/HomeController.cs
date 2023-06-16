using Microsoft.AspNetCore.Mvc;

namespace MemberManagerApi
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
