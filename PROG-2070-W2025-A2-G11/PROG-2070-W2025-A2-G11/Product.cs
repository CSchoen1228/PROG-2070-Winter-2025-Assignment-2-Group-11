
namespace PROG_2070_W2025_A2_G11
{
    public class Product
    {

        private int _prodId;
        public int ProdID { get=>_prodId;
            set {
                if (value < 5 || value > 50000)
                {
                    throw new Exception(message: "Id out of Range");
                }
                _prodId = value;
            }
        }

        private string _prodName;
        public string? ProdName { get => _prodName; 
            set
            {
                if (String.IsNullOrEmpty(value?.Trim()))
                {
                    throw new Exception(message: "Name can not be empty");
                }
                _prodName = value;
            } 
        }

        private decimal _itemPrice;
        public decimal ItemPrice { get =>_itemPrice;
            set
            {
                if (value < 5 || value > 5000)
                {
                    throw new Exception(message: "Price out of Range");
                }
                _itemPrice = value;
            }
        }

        private int _stockAmount;
        public int StockAmount { get=>_stockAmount;
            set
            {
                if (value < 5 || value > 500000)
                {
                    throw new Exception(message: "Stock Amount out of Range");
                }
                _stockAmount = value;
            }
        }
        

        public Product(int ProdID, string ProdName, decimal ItemPrice, int StockAmount)
        {
            this.ProdID = ProdID;
            this.ProdName = ProdName;
            this.ItemPrice = ItemPrice;
            this.StockAmount = StockAmount;
        }

        public void Increase(int amount)
        {
            if (amount <= 0)
            {
                throw new Exception(message: "amount can not be less than 1");
            }
            StockAmount += amount;
        }

        public void Decrease(int amount)
        {
            if (amount <= 0)
            {
                throw new Exception(message: "amount can not be less than 1");
            }
            StockAmount -= amount;
        }

    }
}
