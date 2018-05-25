namespace Counter.ThingsToCount
{
    public class Apple : ICountable
    {
        public Apple(string colour)
        {
            Colour = colour;
        }
        public string Colour { get; }
        public int Count => 1;
    }
}
