﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.ProductName = "Masa";
            product1.CategoryId = 2;
            product1.UnitPrice = 500;
            product1.UnitInstock = 4;

            Product product2 = new Product { Id=2,CategoryId=5,UnitPrice=35,
            UnitInstock=8,ProductName="kal em"};


            ProductManager productManager = new ProductManager();
            productManager.Add(product1);




        }
    }
}
