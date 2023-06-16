﻿using MemberManagerLibrary;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MemberManagerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        IMemberManager _mgr;

        public MemberController(IMemberManager mgr)
        {
            _mgr = mgr;
        }

        // GET: api/<MemberController>
        [HttpGet]
        public IEnumerable<Member> Get()
        {
            return _mgr.GetAll();
        }

        // GET api/<MemberController>/5
        [HttpGet("{id}")]
        public ActionResult<Member> Get(int id)
        {
            var member = _mgr.FindById(id);
            if (member == null)
            {
                return NotFound();
            }
            return member;
        }

        // POST api/<MemberController>
        [HttpPost]
        public ActionResult<Member> Post([FromBody] Member memberToAdd)
        {
            Member addedMember = _mgr.AddMember(memberToAdd);

            return Created($"/api/Member/{ addedMember.Id}", addedMember);
            //return CreatedAtAction(nameof(Member), 
            //                        new { id = memberToAdd.Id }, 
            //                        addedMember);
        }

        // PUT api/<MemberController>/5
        [HttpPut("{id}")]
        public Member Put(int id, [FromBody] Member memberToUpdate)
        {
            _mgr.Update(memberToUpdate);
            return memberToUpdate;
        }

        // DELETE api/<MemberController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _mgr.Delete(id);
        }
    }
}
