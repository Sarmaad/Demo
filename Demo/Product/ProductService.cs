namespace ProductNS
{
    public class ProductService
    {
        public Product[] GetProducts()
        {

            return new[]
            {
                new Product(1, "Apple Pie", 12.95m, 5),
                new Product(2, "Apple Juice", 5.95m, 5),

            };
        }
    }
}
