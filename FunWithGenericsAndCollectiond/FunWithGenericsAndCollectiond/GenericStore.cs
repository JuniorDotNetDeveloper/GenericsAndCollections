using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithGenericsAndCollectiond
{
    public class GenericStore<T>
    {
        private readonly int _maxSize = 50;
        private readonly int _currentSize;
        //private int _currentIndex = 0;
        private T[] _item;

        public GenericStore(int size)
        {
            _currentSize = size;
            _item = new T[_currentSize];
        }

        internal T Get(int index)
        {
            if (index < _maxSize && _item[index] != null)
                return _item[index];
            throw new IndexOutOfRangeException();
        }

        internal void Set(int index, T value)
        {
            if (index < _currentSize)
            {
                _item[index] = value;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        internal void ChangeValues(int index1, int index2)
        {
            if (index1 < _currentSize && index2 < _currentSize)
            {
                T temp = _item[index1];
                _item[index1] = _item[index2];
                _item[index2] = temp;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
}