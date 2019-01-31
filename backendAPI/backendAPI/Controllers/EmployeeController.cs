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
    [Route("Employee")]
    public class EmployeeController : ControllerBase
    {
        private readonly NarfoContext _db;
        public EmployeeController(NarfoContext db)
        {
            _db = db;
            if (!_db.Employees.Any())
            {
                Employee newEmployee = new Employee();
                newEmployee.Name = "admin";
                newEmployee.Surname = "admin";
                newEmployee.Gender = "admin";
                newEmployee.DOB = "admin";
                newEmployee.Status = true;

                _db.Employees.AddAsync(newEmployee);
                _db.SaveChanges();
            }

        }

        [HttpGet("get/all")]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployeesAsync()
        {
            return await _db.Employees.ToListAsync();
        }

        [HttpGet("get/{id}")]
        public async Task<ActionResult<Employee>> GetEmployeesAsync(int id)
        {
            return await _db.Employees.FindAsync(id);
        }

        [HttpPost("set")]
        public async Task<ActionResult<Employee>> SetEmployee(Employee newEmployee)
        {

            await _db.Employees.AddAsync(newEmployee);
            await _db.SaveChangesAsync();
            return newEmployee;
        }

        [HttpPost("login")]
        public async Task<ActionResult<Employee>> LoginEmployee(Employee newEmployee)
        {
            // newEmployee.Password = Encript.Encrypt_user(newEmployee.Password);

            Employee Employee = _db.Employees.Find(newEmployee.Name);

            if (Employee.Name == newEmployee.Name)
                return Employee;

            return null;
        }


    }
}