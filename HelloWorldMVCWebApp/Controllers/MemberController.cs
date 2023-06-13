using HelloWorldMVCWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldMVCWebApp.Controllers
{
    public class MemberController : Controller
    {
        private MemberManager mgr = new MemberManager();

        public IActionResult Index()
        {
            ViewBag.Members = mgr.GetAll();
            return View();
        }
    }
}
