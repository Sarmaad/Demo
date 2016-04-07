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
        public decimal Price { get; private set; }
        public int Quantity { get; private set; }           
        public bool IsActive { get; set; }


        public Product(int productId, string productName, decimal price, int qty)
        {
            ProductID = productId;
            ProductName = productName;
            Price = price;
            Quantity = qty;
        }
    }
}
