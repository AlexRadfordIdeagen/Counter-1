namespace Counter.ThingsToCount
{
  public class Apple : ICountable
  {
    public Apple(string colour)
    {
      Colour = colour;
    }

    public int Count => 1;

    public string Colour { get; }
  }
}