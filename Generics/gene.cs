using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_20_ADVC_1.Generics
{
   
        public class Container<T>
        {
            private List<T> items = new List<T>();

            public void Add(T item)
            {
                items.Add(item);
            }

            // Get an item by index
            public T Get(int index)
            {
                return items[index];
            }
        }
    }

