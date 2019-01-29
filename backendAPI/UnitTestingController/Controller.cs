using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingController
{
    class Controller
    {
        private EmployeeController econtroller;
   
        [TestCase(1, "just a name")]
     
        public void Get(int value,string outcome)
        {

            //arrange
            //act
            //assert
           
            var x = econtroller.Get(value);
            Assert.AreEqual(outcome, x);
        }


       


    }
}
