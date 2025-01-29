using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
