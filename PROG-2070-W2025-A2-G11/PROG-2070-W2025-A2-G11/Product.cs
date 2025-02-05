namespace PROG_2070_W2025_A2_G11
{
    /// <summary>
    /// Product class to store product information
    /// </summary>
    public class Product
    {
        //private fields
        private int _prodId;
        private string _prodName;
        private double _itemPrice;
        private int _stockAmount;

        //public properties
        public int ProdId 
        { 
            get=>_prodId;
            set {
                if (value < 5 || value > 50000)
                {
                    throw new Exception(message: "Id out of Range");
                }
                _prodId = value;
            }
        }

        public string? ProdName 
        { 
            get => _prodName; 
            set
            {
                if (String.IsNullOrEmpty(value?.Trim()))
                {
                    throw new Exception(message: "Name cannot be empty");
                }
                _prodName = value;
            } 
        }

        public double ItemPrice 
        { 
            get =>_itemPrice;
            set
            {
                if (value < 5 || value > 5000)
                {
                    throw new Exception(message: "Price out of Range");
                }
                _itemPrice = value;
            }
        }
       
        public int StockAmount 
        { 
            get=>_stockAmount;
            set
            {
                if (value < 5 || value > 500000)
                {
                    throw new Exception(message: "Stock Amount out of Range");
                }
                _stockAmount = value;
            }
        }

        //constructor
        public Product(int prodId, string prodName, double itemPrice, int stockAmount)
        {
            this.ProdId = prodId;
            this.ProdName = prodName;
            this.ItemPrice = itemPrice;
            this.StockAmount = stockAmount;
        }

        //Method to increase stock amount
        public void Increase(int amount)
        {
            if (amount <= 0)
            {
                throw new Exception(message: "Amount cannot be less than 1");
            }
            StockAmount += amount;
        }

        //Method to decrease stock amount
        public void Decrease(int amount)
        {
            if (amount <= 0)
            {
                throw new Exception(message: "Amount cannot be less than 1");
            }
            StockAmount -= amount;
        }

    }
}
