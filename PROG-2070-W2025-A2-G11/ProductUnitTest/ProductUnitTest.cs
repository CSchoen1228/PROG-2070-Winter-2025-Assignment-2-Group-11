using PROG_2070_W2025_A2_G11;

namespace ProductnUnitTests
{
    public class ProductTests
    {
        private Product _product { get; set; } = null;
        [SetUp]
        public void Setup()
        {
            _product = new Product(5, "Test Product", 100, 50);
        }

        // Test cases for Product class's ProdId field, the accepted value range is 5 to 50000
        // Test cases test for values below, within and above the accepted range
        [TestCase(4)]
        [TestCase(1000)]
        [TestCase(50001)]
        public void ProdIdIsInRange_Test(int prodId)
        {
            // Arrange
            _product.ProdID = prodId;

            // Act
            var actualProdId = _product.ProdID;

            // Assert

            Assert.That(actualProdId, Is.InRange(5, 50000));
        }


        // Test cases for Product class's ItemPrice field, the accepted value range is 5 to 5000
        // Test cases test for values below, within and above the accepted range
        [TestCase(4)]
        [TestCase(4999)]
        [TestCase(5001)]
        public void ItemPriceIsInRange_Test(int itemPrice)
        {
            // Arrange
            _product.ItemPrice = itemPrice;
            // Act
            var actualItemPrice = _product.ItemPrice;

            // Assert

            Assert.That(actualItemPrice, Is.InRange(5, 5000));
        }

        // Test cases for Product class's Stock field, the accepted value range is 5 to 500000
        // Test cases test for values below, within and above the accepted range
        [TestCase(4)]
        [TestCase(100000)]
        [TestCase(500001)]
        public void StockAmountIsInRange_Test(int stockAmount)
        {
            // Arrange
            _product.StockAmount = stockAmount;
            // Act
            var actualStockAmount = _product.StockAmount;

            // Assert

            Assert.That(actualStockAmount, Is.InRange(5, 500000));
        }

        // Test cases for Product class's Stock Increase method
        [TestCase(4)]
        [TestCase(100000)]
        [TestCase(500000)]
        public void StockIncrease_Test(int amount)
        {
            // Arrange
            _product.Increase(amount);

            // Act
            var actualStockAmount = _product.StockAmount;

            // Assert
            Assert.That(actualStockAmount, Is.InRange(5, 500000));
        }

        // Test cases for Product class's Stock Decrease method
        [TestCase(4)]
        [TestCase(100000)]
        [TestCase(500000)]
        public void StockDecrease_Test(int amount)
        {
            // Arrange
            _product.Decrease(amount);

            // Act
            var actualStockAmount = _product.StockAmount;

            // Assert
            Assert.That(actualStockAmount, Is.InRange(5, 500000));
        }

        // Test cases for Product class's Stock Decrease method
        [TestCase("")]
        [TestCase("Apple")]
        [TestCase(null)]
        public void ProdNameIsValid_Test(string? name)
        {
            // Arrange
            _product.ProdName = name;

            // Act
            var actualName = _product.ProdName;

            // Assert
            Assert.That(actualName.Length, Is.GreaterThanOrEqualTo(2));
        }
    }
}