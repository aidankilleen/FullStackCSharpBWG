using MemberManagerLibrary;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MemberManagerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OriginalMemberController : ControllerBase
    {
        IMemberManager _mgr;

        public OriginalMemberController(IMemberManager mgr)
        {
            this._mgr = mgr;
        }

        [HttpGet]
        public List<Member> GetMembers()
        {
            return _mgr.GetAll();
        }

        [HttpGet("{id}")]
        public Member? GetMember(int id)
        {
            return _mgr.FindById(id);
        }
    }
}
