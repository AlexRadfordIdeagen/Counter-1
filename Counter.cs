using System;

namespace Counter
{
    public class Counter<T> where T : ICountable
    {
        private int count;
     Func<T, bool> countFilter;

        public Counter(Func<T, bool> countFilter)
        {
            this.countFilter = countFilter;
        }

        public Counter() : this(thing => true)
        {

        }
        public void Add(T item)
        {
            if (countFilter(item))
            {
                count += item.Count;
            }
        }

        public int Count => count;

    }
}