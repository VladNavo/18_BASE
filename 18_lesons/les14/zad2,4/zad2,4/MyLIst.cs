using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2_4
{
    internal class MyList<T> : IEnumerable<T>
    {
        private List<T> items;

        public int Count
        {
            get { return items.Count; }
        }

        public MyList()
        {
            items = new List<T>();
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index > items.Count)
                {
                    throw new IndexOutOfRangeException();
                }

                else
                {
                    return items[index];
                }

            }
        }
        public void Add(T item)
        {
            items.Add(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        
    }
}
