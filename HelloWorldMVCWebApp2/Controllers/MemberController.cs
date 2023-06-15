
using MemberManagerLibrary;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace HelloWorldMVCWebApp2.Controllers
{
    public class MemberController : Controller
    {
        private IMemberManager mgr;// = new MemberManager();
        private readonly ILogger<MemberController> _logger;

        public MemberController(IMemberManager mgr, 
                ILogger<MemberController> logger)
        {
            this.mgr = mgr;
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Members = mgr.GetAll();
            return View();
        }

        public IActionResult Detail(int? id) {

            ViewBag.Id = id;
            ViewBag.Mbr = mgr.FindById((int)id);

            return View();
        }

        public IActionResult Add()
        {
            _logger.LogInformation("GET request received");
            ViewBag.Title = "Add Member";
            return View("MemberForm");
        }

        [HttpPost]
        public IActionResult Add(Member member)
        {
            // handle the post request
            _logger.LogInformation("POST request received");
            _logger.LogInformation($"{member}");

            // TBD - actually save the member...
            mgr.AddMember(member);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Member member = mgr.FindById(id);

            ViewBag.Mbr = member;
            return View();
        }
        [HttpPost]
        public IActionResult Delete(int id, 
                                    string submit)
        {
            _logger.LogInformation(submit);
            

            if (submit.Equals("Ok"))
            {
                mgr.Delete(id);
            }

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            ViewBag.Title = "Edit Member";

            var member = mgr.FindById(id);
            return View("MemberForm", member);
        }

        [HttpPost]
        public IActionResult Edit(int id, Member member )
        {
            _logger.LogInformation($"{member}");

            mgr.Update(member);

            return RedirectToAction("Index");
        }
    }
}
