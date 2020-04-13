using ACM.BL;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Acme.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            //Arrange
            var changedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {   
                EmailAdress = "fbaggins@hobbiton.me",
                FirstName = "Bilbo",
                LastName = "Baggins",
                AddressList = null
            };
            changedItems.Add(customer);

            var product = new Product(2)
            {
                Description = "Test",
                CurrentPrice = 18.60m,
                Name = "Test"
            };
            changedItems.Add(product);

            //Act
            LoggingService.WriteToFile(changedItems);

            Assert.IsTrue(true);

        }
    }
}
