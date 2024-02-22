using System;

namespace EventsAndDelegatesDemo
{
    public class Car
    {
        // Delegates without EventArgs
        public delegate void ReachedTopSpeedEventHandler();
        public event ReachedTopSpeedEventHandler ReachedTopSpeed;

        public delegate void ApproachingSpeedOfSoundEventHandler();
        public event ApproachingSpeedOfSoundEventHandler ApproachingSpeedOfSound;

        public delegate void SpeedOfSoundReachedEventHandler();
        public event SpeedOfSoundReachedEventHandler SpeedOfSoundReached;

        // Delegates with EventArgs
        public delegate void ReportSpeedEventHandler(CarSpeedEventArgs e);
        public event ReportSpeedEventHandler ReportSpeed;

        private string _name;

        public Car(string Name)
        {
            _name = Name;
        }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }

        public void Accelerate()
        {
            int kphSpeed = 0;
            while (kphSpeed < 1300)
            {
                kphSpeed++;

                // Report speed in multiples of 100
                if (kphSpeed % 100 == 0)
                {
                    OnReportSpeed(kphSpeed);
                }

                // Raise event depending on condition
                if (kphSpeed == 1235)
                {
                    OnSpeedOfSoundReached();
                }
                else if (kphSpeed == 1200)
                {
                    OnApproachingSpeedOfSound();
                }
            }
            OnReachedTopSpeed();
        }

        private void OnReportSpeed(int kphSpeed)
        {
            if (ReportSpeed != null)
                ReportSpeed(new CarSpeedEventArgs(kphSpeed));
        }

        protected virtual void OnApproachingSpeedOfSound()
        {
            if (ApproachingSpeedOfSound != null)
                ApproachingSpeedOfSound();
        }

        private void OnSpeedOfSoundReached()
        {
            if (SpeedOfSoundReached != null)
                SpeedOfSoundReached();
        }

        private void OnReachedTopSpeed()
        {
            if (ReachedTopSpeed != null)
                ReachedTopSpeed();
        }
    }
}
