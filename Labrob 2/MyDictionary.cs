using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Labrob_2 
{
    class MyDictionary<T, R> : IEnumerable
    {
        T[] Key = new T[0];

        R[] Value = new R[0]; 

        public int count { get { return Key.Length; } }

        public IEnumerator<KeyValuePair<T, R>> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
                yield return new KeyValuePair<T, R>(Key[i], Value[i]);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public R this[T key] 
        {
            get
            {
                int ind = 0;
                for (int i = 0; i < count; i++)
                {
                    if (key.Equals(Key[i]))
                        ind = i;
                }
                return Value[ind];
            }
            set
            {
                int ind = 0;
                for (int i = 0; i < count; i++)
                {
                    if (key.Equals(Key[i]))
                        ind = i;
                }
                Value[ind] = value;
            }
        }

        public void Add(T key, R value)
        {
            T[] newKey = new T[Key.Length + 1];
            Key.CopyTo(newKey, 0);
            newKey[Key.Length] = key;
            Key = newKey;

            R[] newValue = new R[Value.Length + 1];
            Value.CopyTo(newValue, 0);
            newValue[Value.Length] = value;
            Value = newValue;
        }
    }
}
