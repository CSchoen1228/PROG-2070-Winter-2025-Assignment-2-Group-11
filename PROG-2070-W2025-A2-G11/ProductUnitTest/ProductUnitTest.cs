using PROG_2070_W2025_A2_G11;

namespace ProductnUnitTests
{
    /// <summary>
    /// Test class for Product class
    /// </summary>
    public class ProductTests
    {

        //Private field for Product object that will be tested
        private Product? _product { get; set; }
        
        [SetUp]
        public void Setup()
        {
            _product = new Product(5, "Product 1", 100, 50);
        }

        // Test cases for Product class's ProdId field, the accepted value range is 5 to 50000
        // Test cases test for values below and above the accepted range
        [TestCase(4)]
        [TestCase(50001)]
        public void ProdIdThrowsOutOfRange_Test(int prodId)
        {
            //Arrange, Act and Assert gets complicated with Assert.Throws
            Assert.Throws<Exception>(()=>_product.ProdId=prodId);
            
        }

        //Test Case for ProdId is in range
        [Test]
        public void ProdIdIsInRange_Test()
        {
            //Arrange
            int prodId = 7;

            //Act
            _product.ProdId = prodId;

            //Assert
            Assert.That(_product.ProdId, Is.InRange(5,50000));
        }


        // Test cases for Product class's ItemPrice field, the accepted value range is 5 to 5000
        // Test cases test for values belowand above the accepted range
        [TestCase(4)]
        [TestCase(5001)]
        public void ItemPriceThrowsOutOfRange_Test(int itemPrice)
        {
            //Arrange, Act and Assert gets complicated with Assert.Throws
            Assert.Throws<Exception>(() => _product.ItemPrice = itemPrice);
        }

        [Test]
        public void ItemPriceIsInRange_Test()
        {
            //Arrange
            int price = 7;

            //Act
            _product.ItemPrice = price;

            //Assert
            Assert.That(_product.ItemPrice, Is.InRange(5, 5000));
        }

        // Test cases for Product class's Stock field, the accepted value range is 5 to 500000
        // Test cases test for values below, within and above the accepted range
        [TestCase(4)]
        [TestCase(500001)]
        public void StockAmountThrowsOutOfRange_Test(int stockAmount)
        {
            //Arrange, Act and Assert gets complicated with Assert.Throws
            Assert.Throws<Exception>(() => _product.StockAmount = stockAmount);
        }

        [Test]
        public void StockAmountIsInRange_Test()
        {
            //Arrange
            int stock = 7;

            //Act
            _product.StockAmount = stock;

            //Assert
            Assert.That(_product.StockAmount, Is.InRange(5, 500000));
        }
        
        //Test case for Stock increase properly increasing
        [Test]
        public void StockIncreaseIsValid_Test()
        {
            //Arrange
            int start = 200;
            int increase = 5;
            _product.StockAmount = start;

            //Act
            _product.Increase(increase);

            //Assert
            Assert.That(_product.StockAmount, Is.EqualTo(start + increase));
        }

        [Test]
        public void StockIncreaseNegativeValue_Test()
        {
            //Arrange
            int start = 200;
            int increase = -5;
            _product.StockAmount = start;

            //Act & Assert
            Assert.Throws<Exception>(()=>_product.Increase(increase));
        }

        [Test]
        public void StockIncreaseOutOfRange_Test()
        {
            //Arrange
            int start = 200;
            int increase = 1000000;
            _product.StockAmount = start;

            //Act & Assert
            Assert.Throws<Exception>(() => _product.Increase(increase));
        }

        //Test case for Stock decrease properly decreasing
        [Test]
        public void StockDecreaseIsValid_Test()
        {
            //Arrange
            int start = 200;
            int decrease = 5;
            _product.StockAmount = start;

            //Act
            _product.Decrease(decrease);

            //Assert
            Assert.That(_product.StockAmount, Is.EqualTo(start - decrease));
        }

        [Test]
        public void StockDecreaseNegativeValue_Test()
        {
            //Arrange
            int start = 200;
            int decrease = -5;
            _product.StockAmount = start;

            //Act & Assert
            Assert.Throws<Exception>(() => _product.Decrease(decrease));
        }

        [Test]
        public void StockDecreaseOutOfRange_Test()
        {
            //Arrange
            int start = 200;
            int decrease = 1000000;
            _product.StockAmount = start;

            //Act & Assert
            Assert.Throws<Exception>(() => _product.Decrease(decrease));
        }

        [Test]
        public void ProdNameIsValid_Test()
        {
            //Arrange
            string name = "Product 1";

            //Act
            _product.ProdName = name;

            //Assert
            Assert.That(_product.ProdName, Is.EqualTo(name));
        }

        [Test]
        public void ProdNameIsEmpty_Test()
        {
            //Arrange
            string name = string.Empty;

            //Act & Assert
            Assert.Throws<Exception>(()=>_product.ProdName = name);
        }

        [Test]
        public void ProdNameIsNull_Test()
        {
            //Arrange
            string? name = null;

            //Act & Assert
            Assert.Throws<Exception>(() => _product.ProdName = name);
        }
    }
}