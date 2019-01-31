using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFromDatabase.Test
{
    public class Tests
    {
        private ReadData read;

        public Tests()
        {
            read = new ReadData();
        }

        [TestCase]
        public void ReadDatabase()
        {
            //asign
            var readTest = read.DBConnection();
            //act
            //Assert
            Assert.AreEqual("admin", readTest);
        }
    }
}
