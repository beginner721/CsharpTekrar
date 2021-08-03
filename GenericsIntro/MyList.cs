using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //ctor - constructor, bu MyList classı newlendiği anda alttaki ctor çalışır
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; //items in referansını aldık tempArray'e bu şekilde kaybolmayacak.
            items = new T[items.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];

            }

            items[items.Length - 1] = item; //eksi bir çünkü length eleman sayısını verir bir eksiği ise tam yerini verecektir.
        }
    }
}
