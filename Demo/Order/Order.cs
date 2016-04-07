using System.Collections.Generic;
using System.Linq;


namespace Order
{
    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }

        public List<Product> Products { get; set; }

        public decimal Total
        {
            get { return Products.Sum(x => x.Total); }
        }
    }

    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get { return Quantity*Price; } }
    }
}
