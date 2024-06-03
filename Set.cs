using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Set<T> : IEnumerable<T>
    {
        private Dictionary<T, object> _elements;

        public Set()
        {
            _elements = new Dictionary<T, object>();
        }

        public int Count => _elements.Count;

        public bool Add(T item)
        {
            if (_elements.ContainsKey(item))
            {
                return false;
            }

            _elements[item] = null;
            return true;
        }

        public bool Remove(T item)
        {
            return _elements.Remove(item);
        }

        public bool Contains(T item)
        {
            return _elements.ContainsKey(item);
        }

        public void Clear()
        {
            _elements.Clear();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _elements.Keys.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
