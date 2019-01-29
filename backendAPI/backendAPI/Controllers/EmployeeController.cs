using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using backendAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace backendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeContext _db;
        public EmployeeController(EmployeeContext context)
        {
            _db = context;
        }

        // GET api/Employee
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> Get()
        {
            return await _db.employees.ToListAsync();
        }

        // GET api/Employee/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> Get(int id)
        {
            return await _db.employees.FindAsync(id);
        }

        // POST api/Employee
        [HttpPost]
        public async Task Post([FromBody] Employee value)
        {
            await _db.employees.AddAsync(value);
            await _db.SaveChangesAsync();
        }

        // PUT api/Employee/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] Employee value)
        {
            var entry = await _db.employees.FindAsync(id);
            entry = value;
            await _db.SaveChangesAsync();
        }

        // DELETE api/Employee/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            var entry = await _db.employees.FindAsync(id);
            _db.employees.Remove(entry);
            await _db.SaveChangesAsync();
        }
    }
}
