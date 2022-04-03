using lesson_10.Business;
using lesson_10.DataAccess;
using System;
using System.Collections.Generic;

namespace lesson_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sandėlyje turime šias prekes:\r\n");

            ProductRepository prodRep = new ProductRepository();
            List<Product> productsList = prodRep.Retrieve();

            for (int i = 0; i < productsList.Count; i++)
            {
                Console.Write($"{productsList[i].Name}, {productsList[i].Description}, {productsList[i].CurrentPrice}\r\n");
            }

            Console.WriteLine("");
            //--------------------------------------------------------------------
            // sukurti nauja uzsakyma ir atvaizduoti jo informacija su produktais
            //--------------------------------------------------------------------
           
            OrderRepository ordRep = new OrderRepository();
            List<OrderProduct> orderedProduct = ordRep.Retrieve();
                   
            Order newOrder = new Order(DateTime.Now, "Klaipedos m., Ruko g. 14, LT-92651", orderedProduct);


            Console.Write($"Jusu uzsakymas: {newOrder.OrderDate}, {newOrder.ShippingAdress}\r\n");
            Console.WriteLine($"Užsakymas:");
            for (int i = 0; i < orderedProduct.Count; i++)
            {
                Console.Write($"Produktas: {orderedProduct[i].Product.Name}, kiekis: {orderedProduct[i].Quantity}\r\n");
            }
            Console.WriteLine($"Bendra suma už produktus: {ordRep.CountPrice()}");

        }
    }
}
