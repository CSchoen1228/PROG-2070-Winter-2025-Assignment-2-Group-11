using PROG_2070_W2025_A2_G11;

namespace ProductUnitTest
{
    public class ProductTests
    {
        private Product _product { get; set; } = null;
        [SetUp]
        public void Setup()
        {
            _product = new Product(5, "Test Product", 10.00m, 10);
        }

        [TestCase]
        //[TestCase(5)]
        //[TestCase(100)]
        //[TestCase(50000)]
        //[TestCase(50001)]
        public void ProductIdIsInRange_Test()
        {
            // Arrange
            //var prodID = 5;

            // Act
            var prodId = _product.ProdID;

            // Assert

            Assert.That(prodId, Is.EqualTo(5));

        }
    }
}