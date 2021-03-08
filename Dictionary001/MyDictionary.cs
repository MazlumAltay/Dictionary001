using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary001
{
    class MyDictionary<T, K>
    {
        T[] keys;
        K[] values;

        public MyDictionary()
        {
            keys = new T[0];
            values = new K[0];
        }

        public void Add(T key, K value)
        {
            T[] tempKey = keys;
            K[] tempValue = values;
            keys = new T[keys.Length + 1];
            values = new K[values.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
                values[i] = tempValue[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }
        public T[] TItems
        {
            get { return keys; }
        }
        public K[] KItems
        {
            get { return values; }
        }
    }
}
