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
        // Test cases test for values below and above the accepted range
        [TestCase(4)]
        [TestCase(50001)]
        public void ProdIdThrowsOutOfRange(int prodId)
        {
            //Arrange, Act and Assert gets complicated with Assert.Throws

            Assert.Throws<Exception>(()=>_product.ProdID=prodId);
            
        }

        //Test Case for prod id is in range
        [Test]
        public void ProdIdInRange()
        {
            //Arrange
            int prodId = 7;

            //Act
            _product.ProdID = prodId;

            //Assert
            Assert.That(_product.ProdID, Is.InRange(5,50000));
        }


        // Test cases for Product class's ItemPrice field, the accepted value range is 5 to 5000
        // Test cases test for values belowand above the accepted range
        [TestCase(4)]
        [TestCase(5001)]
        public void ItemPriceThrowsOutOfRange(int itemPrice)
        {
            //Arrange, Act and Assert gets complicated with Assert.Throws

            Assert.Throws<Exception>(() => _product.ItemPrice = itemPrice);

        }

        [Test]
        public void ItemPriceInRange()
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
        public void StockAmountThrowsOutOfRange(int stockAmount)
        {
            //Arrange, Act and Assert gets complicated with Assert.Throws

            Assert.Throws<Exception>(() => _product.StockAmount = stockAmount);
        }

        [Test]
        public void StockAmountInRange()
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
        public void StockIncreaseNormalFunction()
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
        public void StockIncreaseNegativeValue()
        {
            //Arrange
            int start = 200;
            int increase = -5;
            _product.StockAmount = start;

            //Act & Assert
            Assert.Throws<Exception>(()=>_product.Increase(increase));
        }

        [Test]
        public void StockIncreaseOutOfRange()
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
        public void StockDecreaseNormalFunction()
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
        public void StockDecreaseNegativeValue()
        {
            //Arrange
            int start = 200;
            int decrease = -5;
            _product.StockAmount = start;

            //Act & Assert
            Assert.Throws<Exception>(() => _product.Decrease(decrease));
        }

        [Test]
        public void StockDecreaseOutOfRange()
        {
            //Arrange
            int start = 200;
            int decrease = 1000000;
            _product.StockAmount = start;

            //Act & Assert
            Assert.Throws<Exception>(() => _product.Decrease(decrease));
        }

        [Test]
        public void ProdNameValid()
        {
            //Arrange
            string name = "hi";

            //Act
            _product.ProdName = name;

            //Assert
            Assert.That(_product.ProdName, Is.EqualTo(name));
        }

        [Test]
        public void ProdNameEmpty()
        {
            //Arrange
            string name = string.Empty;

            //Act & Assert
            Assert.Throws<Exception>(()=>_product.ProdName = name);
        }

        [Test]
        public void ProdNameIsNull()
        {
            //Arrange
            string? name = null;

            //Act & Assert
            Assert.Throws<Exception>(() => _product.ProdName = name);
        }
    }
}