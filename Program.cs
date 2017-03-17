using System;
using System.Collections.Generic;
using Counter.ThingsToCount;

namespace Counter
{
  class Program
  {
    static void Main()
    {
      // Some things to count
      var someApples = new List<Apple> {new Apple("Red"), new Apple("Green"), new Apple("Red")};

      var boxOfApples = new Box<Apple>();
      boxOfApples.Add(new Apple("Red"));
      boxOfApples.Add(new Apple("Green"));

      var cart = new Cart<Apple>();
      cart.Add(boxOfApples);

      // Some counters
      var appleCounter = new Counter<Apple>(apple => apple.Colour == "Red");
      someApples.ForEach(appleCounter.Add);

      Console.WriteLine(appleCounter.Count); // Should be 3, no actually now 2 because only 2 of them are red

      var cartCounter = new Counter<Cart<Apple>>();
      cartCounter.Add(cart);

      Console.WriteLine(cartCounter.Count); // Should be 2 (number of apples in the cart in total)

      var anythingCounter = new Counter<ICountable>();
      someApples.ForEach(anythingCounter.Add);
      anythingCounter.Add(cart);

      Console.WriteLine(anythingCounter.Count); // Should be 5 - sum of the above

      Console.ReadLine();
    }
  }
}
