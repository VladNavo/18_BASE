using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Dictionary<TKey,TValue>
    {
        private List<KeyValuePair<TKey, TValue>> items;

        public int Count
        {
            get { return items.Count; }
        }

        public Dictionary()
        {
            items = new List<KeyValuePair<TKey, TValue>>();
        }

        public void Add(TKey key, TValue value) 
        {
            items.Add(new KeyValuePair<TKey, TValue>(key, value));
        }
        public TValue this[TKey key]
        {
            get
            {
                foreach (var item in items)
                {
                    if(EqualityComparer<TKey>.Default.Equals(item.Key, key))
                    {
                        return item.Value;
                    }
                    
                }
                throw new KeyNotFoundException($"Key '{key}' not found in dictionary.");
            }
        }
    }
}
