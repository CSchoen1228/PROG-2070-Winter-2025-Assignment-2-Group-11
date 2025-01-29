using PROG_2070_W2025_A2_G11;

namespace ProductnUnitTests
{
    public class ProductTests
    {
        private Product _product { get; set; } = null;
        [SetUp]
        public void Setup()
        {
            _product = new Product(5, "Test Product", 10.00m, 10);
        }

        [TestCase(4, 4)]
        [TestCase(5, 5)]
        [TestCase(100, 100)]
        [TestCase(50000, 50000)]
        [TestCase(50001, 50001)]
        public void ProductIdIsInRange_Test(int prodID, int expected)
        {
            // Arrange
            _product.ProdID = prodID;

            // Act
            var actualProdId = _product.ProdID;

            // Assert

            Assert.That(actualProdId, Is.EqualTo(prodID));

        }
    }
}