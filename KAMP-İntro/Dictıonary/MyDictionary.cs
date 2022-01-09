using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictıonary
{
    public class MyDictionary <Key ,Value>
    {
        Key[] keys;
        Value[] values;
        Key[] tempkeys;
        Key[] tempvalue;
       
       
        public MyDictionary()
        {
            keys = new Key[0];
            values = new Value[0];

        }

     public void Add(Key key,Value value)
        {
            Key[] tempkeys =  keys;
            Value[] tempvalue = values;
            keys = new Key[keys.Length + 1];
            values = new Value[values.Length + 1];

            for (int i = 0; i < tempkeys.Length; i++)
            {
                keys[i] = tempkeys[i];
                values[i] = tempvalue[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
            Console.WriteLine("İstediğiniz Ülke: " + key + ". " +
                "Ülkeye ait Ülke Kodu: " + value);
            Console.ReadLine();
        }

        
    }
}
