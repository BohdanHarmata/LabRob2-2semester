using System;
using System.Collections.Generic;
using System.Text;
namespace Labrob_2
{
    class MyList<T>
    {
       public T[] list = new T[0];

        public int Length { get { return list.Length; } }


        public T this[int i]
        {
            get
            {
                if (i > list.Length && i < 0) throw new IndexOutOfRangeException();
                return list[i];
            }
            set
            {
                if (i > list.Length && i < 0) throw new IndexOutOfRangeException();
                list[i] = value;
            }
        }

        public void Add(T value)
        {
            T[] newList = new T[list.Length + 1];
            list.CopyTo(newList, 0);
            newList[list.Length] = value;
            list = newList;
        }


    }

}


