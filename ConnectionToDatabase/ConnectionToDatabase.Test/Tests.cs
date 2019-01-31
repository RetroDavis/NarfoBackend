using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionToDatabase.Test
{
    public class Tests
    {
        private Connection connect;

        public Tests()
        {
            connect = new Connection();
        }

        [TestCase]
        public void DatabaseConnection()
        {
            //assign
            var Opentest = connect.DBConnection();

            //act
            //assert
            Assert.AreEqual("Open", Opentest);

        }
    }
}
