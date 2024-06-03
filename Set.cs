using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Set<T>
    {
        private HashSet<T> _elements;

        public Set()
        {
            _elements = new HashSet<T>();
        }

        public int Count => _elements.Count;

        public bool IsEmpty => _elements.Count == 0;

        public void Add(T item)
        {
            _elements.Add(item);
        }

        public void Remove(T item)
        {
            _elements.Remove(item);
        }

        public void Clear()
        {
            _elements.Clear();
        }

        public T[] ToArray()
        {
            T[] array = new T[_elements.Count];
            _elements.CopyTo(array);
            return array;
        }

        public bool Contains(T item)
        {
            return _elements.Contains(item);
        }
    }
}
