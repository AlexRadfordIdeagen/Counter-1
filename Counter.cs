namespace Counter
{
  public class Counter<T> where T : ICountable
  {
    private int count;

    public void Add(T item)
    {
      count += item.Count;
    }

    public int Count => count;
  }
}