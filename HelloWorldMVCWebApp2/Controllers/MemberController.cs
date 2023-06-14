using HelloWorldMVCWebApp2.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldMVCWebApp2.Controllers
{
    public class MemberController : Controller
    {
        private MemberManager mgr = new MemberManager();

        public IActionResult Index()
        {
            ViewBag.Members = mgr.GetAll();
            return View();
        }

        public IActionResult Detail(int? id) {

            ViewBag.Id = id;

            
            return View();
        }
    }
}
