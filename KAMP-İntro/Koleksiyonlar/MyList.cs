using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar
{
    public class MyList<T>
    {
        T[] items; //clası newlwdıgmde oluşturmam gerekıyro oyuzden ctor
        public MyList()
        {
            items = new T[0];

        }
           public void Add(T item)
        {
            T[] tempArray = items;

            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }

      


    }
}
