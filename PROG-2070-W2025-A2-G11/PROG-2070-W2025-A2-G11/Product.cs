
namespace PROG_2070_W2025_A2_G11
{
    public class Product
    {
        public int ProdID { get; set; }
        public string ProdName { get; set; }
        public decimal ItemPrice { get; set; }
        public int StockAmount { get; set; }

        public Product(int ProdID, string ProdName, decimal ItemPrice, int StockAmount)
        {
            if( ProdID <5 || ProdID>50000)
            {
                throw new Exception(message:"Id out of Range");
            }
            this.ProdID = ProdID;
            this.ProdName = ProdName;
            this.ItemPrice = ItemPrice;
            this.StockAmount = StockAmount;
        }

        public void Increase(int amount)
        {
            StockAmount += amount;
        }

        public void Decrease(int amount)
        {
            StockAmount -= amount;
        }

    }
}
