using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bus bus = new Bus("test", "test", "test", 34, 43);
            Console.WriteLine(bus.Info());

        }
    }
}
