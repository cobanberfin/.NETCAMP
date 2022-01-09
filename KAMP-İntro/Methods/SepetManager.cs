using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class SepetManager
    {

        public void Ekle(Product product)
        {
            Console.WriteLine("sepete eklendı:" +product.Name);

        }
        public void Ekle2(string name,string description,double price,int stok)
        {
            Console.WriteLine("sepete eklendı:" + name);

        }


    }
}
