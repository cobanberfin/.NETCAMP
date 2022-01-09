using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RealCustomer customer1 = new RealCustomer();
            customer1.CustomerNumber = "1234";
            customer1.CustomerName = "berfin";
            customer1.TCNumber = "21348";
            customer1.Id = 1;

            //kodlama.io

            LegalCustomer customer2 = new LegalCustomer();
            customer2.CustomerNumber = "1234";
            customer2.CompanyName = "kodlama.io";
            customer2.TaxNumber = "1324567";
            customer2.Id = 1;

            Customer customer3 = new RealCustomer();
            Customer customer4 = new LegalCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);








        }
    }
}
