using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductNS
{
    public class Product
    {
        public int ProductID { get; private set; }
        public string ProductName { get; private set; }
        public double Price { get; private set; }
        public int Quantity { get; private set; }           // 

        public Product(int productId, string productName, double price, int qty)
        {
            ProductID = productId;
            ProductName = productName;
            Price = price;
            Quantity = qty;
        }
    }
}
