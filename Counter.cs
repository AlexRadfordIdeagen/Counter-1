namespace Counter
{
  public interface ICounter<in T> where T : ICountable
  {
    void Add(T item);

    int Count { get; }
  }

  public class Counter<T> : ICounter<T> where T : ICountable
  {
    private int count;

    public void Add(T item)
    {
      count += item.Count;
    }

    public int Count => count;
  }
}