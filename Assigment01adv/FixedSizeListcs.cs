using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment01adv
{
    internal class FixedSizeList<T>
    {
        private T[] items;
        private int count = 0;

        public FixedSizeList(int capacity)
        {
            items = new T[capacity];
        }

        public void Add(T item)
        {
            if (count >= items.Length)
                throw new InvalidOperationException("List is full.");
            items[count++] = item;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException("Invalid index.");
            return items[index];
        }
    }
}
