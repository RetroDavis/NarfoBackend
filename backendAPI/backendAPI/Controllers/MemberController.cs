using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using backendAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace backendAPI.Controllers
{
    [Route("Member")]
    public class MemberController : ControllerBase
    {
        private readonly NarfoContext _db;
        public MemberController(NarfoContext db)
        {
            _db = db;
            if(!_db.Members.Any())
            {
                Member newMember = new Member();
                newMember.LastName = "admin";
                newMember.Username = "admin";
                newMember.FirstName = "admin";
                newMember.Password = Encript.Encrypt_user("admin");
                _db.Members.AddAsync(newMember);
                _db.SaveChanges();
            }
        
        }
        
        [HttpGet("get/all")]
        public async Task<ActionResult<IEnumerable<Member>>> GetMembersAsync()
        {
            return await _db.Members.ToListAsync();
        }

        [HttpGet("get/{id}")]
        public async Task<ActionResult<Member>> GetMembersAsync(int id)
        {
            return await _db.Members.FindAsync(id);
        }

        [HttpPost("set")]
        public async Task<ActionResult<Member>> SetMember(Member newMember)
        {
          newMember.Password = Encript.Encrypt_user(newMember.Password);
            await _db.Members.AddAsync(newMember);
          await  _db.SaveChangesAsync();
            return   newMember;
        }

        [HttpPost("login")]
        public async Task<ActionResult<Member>> LoginMember(Member newMember)
        {
            // newMember.Password = Encript.Encrypt_user(newMember.Password);

            Member member = _db.Members.Find(newMember.Username);

            if (member.Password == newMember.Password)
                return member;

            return null;
        }


    }
}