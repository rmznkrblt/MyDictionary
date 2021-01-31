using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey,TValue> where TKey : notnull
    {
        private TKey[] _tKey;
        private TValue[] _tValue;
        private MyDictionary<TKey,TValue> _items;

        public MyDictionary()
        {
            _tKey=new TKey[0];
            _tValue=new TValue[0];
        }

        public void Add(TKey tKey, TValue tValue)
        {
            TKey[] tempKey = _tKey;
            TValue[] tempValue = _tValue;

            _tKey = new TKey[_tKey.Length + 1];
            _tValue = new TValue[_tValue.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                _tValue[i] = tempValue[i];
                _tKey[i] = tempKey[i];
            }

            _tKey[_tKey.Length - 1] = tKey;
            _tValue[_tValue.Length - 1] = tValue;
        }

        public void Items()
        {
            for (int i = 0; i < _tKey.Length; i++)
            {
                Console.WriteLine(_tKey[i] + " " + _tValue[i]);
            }
        }
    }
}
