using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backendAPI.Models
{
    public class Employee
    {
     
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string  Gender{ get; set; }
        public string DOB { get; set; }
        public Boolean Status { get; set; }
    }
}
