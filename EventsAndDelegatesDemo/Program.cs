using System;

namespace EventsAndDelegatesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car("Honda");
            c.ReportSpeed += ReportSpeed;
            c.ApproachingSpeedOfSound += ApproachingSpeedOfSound;
            c.SpeedOfSoundReached += SpeedOfSoundReached;
            c.ReachedTopSpeed += ReachedTopSpeed;
            c.NameChanging += NameChanging;
            c.Name = "Lightning McQueen";
            c.Accelerate();
            Console.ReadLine();
        }

        private static void NameChanging(object sender, CarNameChangingEventArgs e)
        {
            Console.WriteLine(String.Format("Old Name : {0}; New Name : {1}", e.OldName, e.NewName));
        }

        private static void ReportSpeed(CarSpeedEventArgs e)
        {
            Console.WriteLine(e.Speed);
        }

        private static void ApproachingSpeedOfSound()
        {
            Console.WriteLine("Approaching speed of sound...");
        }

        private static void SpeedOfSoundReached()
        {
            Console.WriteLine("Speed of Sound reached!!!");
        }

        private static void ReachedTopSpeed()
        {
            Console.WriteLine("Reached Top Speed!");
        }
    }
}
