using lesson_10.Business;
using System;
using System.Collections.Generic;

namespace lesson_10.DataAccess
{
    public class ProductRepository
    {
        public List<Product> Retrieve()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product("Apvalus stalas", "Nuostabus produktas", 52.99m));
            products.Add(new Product("Stačiakampis stalas", "Labai geras produktas", 48.99m));
            products.Add(new Product("Medinė kėdė", "Prastesnis produktas", 9.99m));
            products.Add(new Product("Plastmasinė kėdė", "Prastas produktas", 6.99m));

            return products;

        }

    }
}
