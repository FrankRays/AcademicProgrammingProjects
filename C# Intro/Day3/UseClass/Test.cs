﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UseClass
{
    class Test
    {
        static void Main(string[] args)
        {
            Customer myCustomer = new Customer(); // value: memory stored in heap
            Console.WriteLine(myCustomer.ToString());

            myCustomer.NewSales(300);
            Console.WriteLine(myCustomer.ToString());

            Customer newCustomer = new Customer("XYZ Company", 500000, "A Contact");
            Console.WriteLine(newCustomer.ToString());

            Console.WriteLine("Read sales of new customer: {0:C}", newCustomer.AnnualSales); // get annualSales

            newCustomer.AnnualSales = 5M;  // set annualSales

            Console.WriteLine("Read sales of new customer: {0:C}", newCustomer.AnnualSales);

        }
    }
}
