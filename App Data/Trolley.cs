using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce_Website
{
    public class Trolley
    {
        public Trolley()
        {

        }

        List<Product> products;

        public List<Product> GetTrolleyContent()
        {
            products = (List<Product>)HttpContext.Current.Session["Trolley"];

            if (products == null)
            {
                products = new List<Product>();
            }
            return products;

        }

        public void SaveTrolleyContent()
        {
            HttpContext.Current.Session["Trolley"] = products;
        }

        public void AddProduct(Product product)
        {
            products = GetTrolleyContent();

            products.Add(product);

            SaveTrolleyContent();
        }

        public int GetProductCount()
        {
            int noOfProducts = 0;

            products = GetTrolleyContent();

            noOfProducts = products.Count();

            return noOfProducts;
        }

        public double GetPriceTotal()
        {
            double total = 0;

            products = GetTrolleyContent();

            foreach (var content in products)
            {
                total = total + content.price;
            }

            return total;
        }

        public void EmptyTrolley()
        {
            products = (List<Product>)HttpContext.Current.Session["Trolley"];

            if (products != null)
            {
                products = new List<Product>();
            }
            SaveTrolleyContent();
        }

        public void DeleteProduct(Product product)
        {
            products = GetTrolleyContent();

            var productToRemove = products.FindIndex(content => content.ItemID == product.ItemID);

            products.RemoveAt(productToRemove);

            SaveTrolleyContent();
        }

    }
}