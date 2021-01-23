using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDict<K,V>
    {
        K[] key;
        V[] value;

        public MyDict()
        {
            key = new K[0];
            value = new V[0];
        }

        public void Add(K keys, V values)
        {
            K[] tempKeys = key;
            V[] tempValues = value;

            key = new K[key.Length + 1];
            value = new V[value.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                key[i] = tempKeys[i];
            }
            key[key.Length - 1] = keys;

            for (int i = 0; i < tempValues.Length; i++)
            {
                value[i] = tempValues[i];
            }
            value[value.Length - 1] = values;


        }

        public void View()
        {
            for (int i = 0; i < key.Length; i++)
            {
                Console.WriteLine(key[i] +" "+ value[i]);
            }
        }

    }
    
}
