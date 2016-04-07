using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Customer;
using CustomerNS;
using ProductNS;
using Order;



namespace Client.Models
{
    public class GetDataFromRepositories
    {
        public int AuthenticateUser()
        {
            CustomerService objCustService = new CustomerService();
            int code = objCustService.Authenicate("test", "test");
            return code;
        }

        public ProductNS.Product[] GetProductDetails()
        {
            int authCode = AuthenticateUser();
            ProductNS.Product[] arrayProd = new ProductNS.Product[2];
            if (authCode ==1)
            {
                ProductService objProductService = new ProductService();
                arrayProd = objProductService.GetProducts();
                return arrayProd;
            }
            return arrayProd;
        }

        public Order.Order PrepareOrder(ProductNS.Product[] prod)
        {
            var objOrder = new Order.Order();
            List<Order.Product> oProducts = new List<Order.Product>();
            
            foreach (var product in prod)
            {
                var objProduct  = new Order.Product();
                objProduct.ProductID = product.ProductID;
                objProduct.ProductName = product.ProductName;
                objProduct.Price = product.Price;
                objProduct.Quantity = 2;
                oProducts.Add(objProduct);
            }
            objOrder = new Order.Order()
            {
                OrderID = 1,
                CustomerID = 1,
                Products = oProducts
            };
            return objOrder;
        }
    }
    public class ESBMediator : IUOW
    {
        public Guid Commit()
        {
            try
            {
                var objPayment = new Payment.Payment();
                GetDataFromRepositories objGetDataFR = new GetDataFromRepositories();
                ProductNS.Product[] prod = objGetDataFR.GetProductDetails();
                var objOrder = (Order.Order)objGetDataFR.PrepareOrder(prod);
                var uID = new Guid();
                if (objPayment.PaymentID == 1 && objOrder != null)
                {
                    return uID;
                }
                return new Guid();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public Guid ROllBack()
        {
            
            return new Guid();
        }
    }
}
