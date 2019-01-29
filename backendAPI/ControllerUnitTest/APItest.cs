using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using backendAPI.Controllers;
using backendAPI.Models;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        private readonly HttpClient _client;
        private readonly EmployeeContext _context;


        private EmployeeController econtroller;


        [TestCase(1, 1)]

        public async Task GetAsync(int value, string outcome)
        {

            //arrange
            //act
            //asse
            var response = await _client.GetAsync($"/get/{value}");
            // Check if status code is OK
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }
       

      


    }
}