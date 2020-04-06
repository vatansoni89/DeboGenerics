using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz.Tests
{
    [TestClass()]
    public class VendorRepositoryTests
    {
        [TestMethod()]
        public void RetrieveValueTest()
        {
            //Arrange
            var repo = new VendorRepository();
            var expected = 42;

            //Act
            var actual= repo.RetrieveValue<int>("",42);

            //Assert
            Assert.AreEqual(expected,actual);
        }
    }
}