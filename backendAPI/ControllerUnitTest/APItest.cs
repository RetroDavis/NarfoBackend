using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using backendAPI.Controllers;
using backendAPI.Models;
using Newtonsoft.Json;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        private readonly HttpClient _client;
        private readonly EmployeeContext _context;


        private EmployeeController econtroller;


        [TestCase(1, "Jack","Zulu","Male","2000/01/01")]

        public async Task Get(int value,string name,string surname,string gender,string dob)
        {

            //arrange
            //act
            //asse
            var worker = new Employee { EmployeeID = value, Name = name, Surname = surname, Gender = gender, DOB= dob };
            var response = await _client.GetAsync($"/get/{value}");
            // Check if status code is OK
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            // Get JSON  of the worker from response
            var jsonResponse = await response.Content.ReadAsStringAsync();
            // Deserialize response JSON to Employee class
            var EmployeeResponse = JsonConvert.DeserializeObject<Employee>(jsonResponse);
            // Check if the employee is the same
            Assert.AreEqual(worker.EmployeeID, EmployeeResponse.EmployeeID);
            Assert.AreEqual(worker.Name, EmployeeResponse.Name);
            Assert.AreEqual(worker.Surname, EmployeeResponse.Surname);
            Assert.AreEqual(worker.Gender, EmployeeResponse.Gender);
            Assert.AreEqual(worker.DOB, EmployeeResponse.DOB);

        }

        [TestCase(1, "Jacky", "Zulu", "Female", "2000/01/01")]

        public async Task Put(int value, string name, string surname, string gender, string dob)
        {

            //arrange
            //act
            //asse
            var worker = new Employee { EmployeeID = value, Name = name, Surname = surname, Gender = gender, DOB = dob };

            // var response = await _client.GetAsync($"/get/{value}");
            var stringContent = new StringContent(worker.ToString());        
            var response = await _client.PutAsync($"/get/{value}", stringContent);

            // Check if status code is OK
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            // Get JSON  of the worker from response
            var jsonResponse = await response.Content.ReadAsStringAsync();
            // Deserialize response JSON to Empoyee class
            var EmployeeResponse = JsonConvert.DeserializeObject<Employee>(jsonResponse);
            // Check if the Employee is the same

            Assert.AreEqual(worker.EmployeeID, EmployeeResponse.EmployeeID);
            Assert.AreEqual(worker.Name, EmployeeResponse.Name);
            Assert.AreEqual(worker.Surname, EmployeeResponse.Surname);
            Assert.AreEqual(worker.Gender, EmployeeResponse.Gender);
            Assert.AreEqual(worker.DOB, EmployeeResponse.DOB);

        }





    }
}