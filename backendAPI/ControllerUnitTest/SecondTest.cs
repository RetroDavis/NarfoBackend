using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using backendAPI.Controllers;
using backendAPI.Models;
using Newtonsoft.Json;
using NUnit.Framework;


namespace ControllerUnitTest
{
   
    public class SecondTest
    {

        [TestCase(1, "Jack", "Zulu", "Male", "2000/01/01")]

        public async Task Get(int value, string name, string surname, string gender, string dob)
        {

            

        }
    }
}
