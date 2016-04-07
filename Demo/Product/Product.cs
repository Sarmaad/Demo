using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductNS
{
    public class Product
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public double Price { get; private set; }

        public int Quantity { get; set; }
    }
}
