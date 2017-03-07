namespace Counter.ThingsToCount
{
  public class Cart<T> : Box<Box<T>> where T:ICountable
  {
  }
}