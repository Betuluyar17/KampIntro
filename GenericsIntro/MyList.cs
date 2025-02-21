using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;

        //constructor
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            //Her new'leme işleminde aşağıdaki stack'e ait referans numarası değişeceği için referans numarasını başka bir referans numarasına sabitledik.

            items = new T[items.Length + 1];
            //Metot her çağırıldığında listeyi +1 artırarak devam ettirir. 

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
            
        }

        public int Length
        {
            get { return items.Length; }
        }

        public T[] Items
        {
            get { return items; }
        } 
    }
}
