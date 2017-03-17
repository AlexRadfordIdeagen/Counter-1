using System;

namespace Counter
{
  public class Counter<T> where T : ICountable
  {
    private int count;
    private readonly Func<T, bool> filter;

    public Counter(Func<T, bool> filter)
    {
      this.filter = filter;
    }

    public Counter() : this(_ => true)
    { 
    }

    public void Add(T item)
    {
      if (filter(item))
      {
        count += item.Count;
      }
    }

    public int Count => count;
  }
}