using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictıonary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> dictionary = new MyDictionary<string, string>();
            dictionary.Add("Türkiye", "TR");
            dictionary.Add("Amerika", "US");
            dictionary.Add("Almanya", "DE");
           

        }
    }
}
