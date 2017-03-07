using System.Collections.Generic;
using System.Linq;

namespace Counter.ThingsToCount
{
  public class Box<T> : ICountable where T : ICountable
  {
    private readonly List<T> contents = new List<T>();

    public void Add(T item)
    {
      contents.Add(item);
    }

    public int Count
    {
      get { return contents.Sum(c => c.Count); }
    }
  }
}