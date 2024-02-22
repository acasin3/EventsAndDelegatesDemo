using System;

namespace EventsAndDelegatesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car("Honda");
            c.ReachedTopSpeed += ReachedTopSpeed;
            c.Accelerate();
            Console.ReadLine();
        }

        private static void ReachedTopSpeed()
        {
            Console.WriteLine("Reached Top Speed!");
        }
    }
}
