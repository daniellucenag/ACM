using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //-- Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(1)
            {
                Description = "Test",
                CurrentPrice = 18.60m,
                Name = "Test"
            };

            //-- Act
            var actual = productRepository.Retrieve(1);

            //-- Assert
            Assert.AreEqual(expected.Id, actual.Id);
            Assert.AreEqual(expected.Description, actual.Description);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.Name, actual.Name);
        }

        [TestMethod()]
        public void SaveTestMissingPrice()
        {
            //Arrenge
            var productRepository = new ProductRepository();
            var updateProduct = new Product(2)
            {
                CurrentPrice = null,
                Description = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers",
                Name = "Sunflowers",
                HasChanges = true
            };

            //Act
            var actual = productRepository.Save(updateProduct);

            //Assert
            Assert.AreEqual(false, actual);

        }

        [TestMethod()]
        public void SaveTestValid()
        {
            //Arrenge
            var productRepository = new ProductRepository();
            var updateProduct = new Product(2)
            {
                CurrentPrice = 18M,
                Description = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers",
                Name = "Sunflowers",
                HasChanges = true
            };

            //Act
            var actual = productRepository.Save(updateProduct);

            //Assert
            Assert.AreEqual(true, actual);
        }
    }
}