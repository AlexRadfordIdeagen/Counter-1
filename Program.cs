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
            var someApples = new List<Apple> { new Apple("Red"), new Apple("Beige"), new Apple("Red"), new Apple("White") };

            var boxOfApples = new Box<Apple>();
            boxOfApples.Add(new Apple("Blue"));
            boxOfApples.Add(new Apple("Black"));
            boxOfApples.Add(new Apple("Red"));
            var cart = new Cart<Apple>();
            cart.Add(boxOfApples);

            // Some counters
            var appleColourCounter = new Counter<Apple>(a => a.Colour == "Red");
            someApples.ForEach(appleColourCounter.Add);
            Console.WriteLine(appleColourCounter.Count); // Result should be 2

            var appleCounter = new Counter<Apple>();
            someApples.ForEach(appleCounter.Add);
            Console.WriteLine(appleCounter.Count); // Result should be 3

            var cartCounter = new Counter<Cart<Apple>>();
            cartCounter.Add(cart);

            Console.WriteLine(cartCounter.Count); // Result is 2

            var anythingCounter = new Counter<ICountable>();
            someApples.ForEach(anythingCounter.Add);
            anythingCounter.Add(cart);

            Console.WriteLine(anythingCounter.Count); // Result is 5

            Console.ReadLine();
        }
    }
}