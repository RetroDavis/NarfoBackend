using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectDatabase;
using ConnectionToDatabase;
using NUnit.Framework;

namespace ConnectDatabase.test
{
    public class Test
    {

        private Connect connector;

        public Test()
        {
            connector = new Connect(); 

        }

        [TestCase]
        public void CheckOpenConnection()
        {
            //assign
            var Opentest = connector.OpenConnection();

            //act
            //assert
            Assert.AreEqual("Open", Opentest);

        }

        [TestCase]
        public void CheckCloseConnection()
        {
            //assign
            var Closetest = connector.CloseConnection();

            //act
            //assert
            Assert.AreEqual("Closed", Closetest);

        }


    }
}
