using System;

namespace EventsAndDelegatesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car("Honda");
            c.Accelerate();
            Console.ReadLine();
        }
    }
}
