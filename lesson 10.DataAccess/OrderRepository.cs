using lesson_10.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_10.DataAccess
{
    public class OrderRepository
    {   
        public List<OrderProduct> Retrieve()
        {
            ProductRepository getProduct = new ProductRepository();
            List<Product> products = getProduct.Retrieve();

  
                List<OrderProduct> orderedProduct = new List<OrderProduct>();
                orderedProduct.Add(new OrderProduct(products[0], 1));
                orderedProduct.Add(new OrderProduct(products[1], 0));
                orderedProduct.Add(new OrderProduct(products[2], 4));
                orderedProduct.Add(new OrderProduct(products[3], 0));

            return orderedProduct;
        }

        public decimal CountPrice()
        {
            List<OrderProduct> orderedProduct = Retrieve();
            decimal price = 0;
            for (int i = 0; i < orderedProduct.Count; i++)
            {
                price += orderedProduct[i].Product.CurrentPrice * orderedProduct[i].Quantity;
            }
            return price;
        }
    }

}
