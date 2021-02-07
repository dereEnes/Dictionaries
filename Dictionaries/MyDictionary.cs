using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionaries
{
    class MyDictionary<TKey,TValue>
    {
        TKey[] keys;
        TValue[] values;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];

        }
        public void Add(TKey key,TValue value)
        {
            TKey[] tempKeys = keys;
            TValue[] tempValues = values;

            keys = new TKey[keys.Length+1];
            values = new TValue[values.Length+1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];

            }
            keys[tempKeys.Length] = key;
            values[tempValues.Length] = value;

        }
        public void ToList()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("Key: {0} , Value: {1}",keys[i],values[i]);
            }
        }
    }
}
