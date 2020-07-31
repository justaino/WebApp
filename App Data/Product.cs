using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce_Website
{
    public class Product
    {

        public int ItemID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public double price { get; set; }

        public byte[] Image { get; set; }


        public Product()
        {

        }

    }
}