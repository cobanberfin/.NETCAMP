using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {// dont repeat yourself- DRY 
         //best practice dogru uygulama teknıklerı


            Product product1 = new Product();

            product1.Name = "elma";
            product1.Price = 15;
            product1.Description = "amasya elması";

            Product product2 = new Product();
            product2.Name = "karpuz";
            product2.Price = 80;
            product2.Description = "dıyarbakır karpuzu";

            Product[] products = new Product[] { product1, product2 };

            foreach (Product item in products)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Price);
                Console.WriteLine(item.Description);

               
            }

            //encapsulation -bır duzenın ıcıne koymka

            SepetManager sepetmanager = new SepetManager();

            sepetmanager.Ekle(product1);
            sepetmanager.Ekle(product2);


            sepetmanager.Ekle2("armut", "yesil", 12,10);
            sepetmanager.Ekle2("elma", "yesil", 8,23);
           







            Console.ReadLine();

        }


    }
}
