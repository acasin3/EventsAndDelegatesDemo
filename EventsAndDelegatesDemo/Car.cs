using System;

namespace EventsAndDelegatesDemo
{
    public class Car
    {
        // Delegates without EventArgs
        public delegate void ReachedTopSpeedEventHandler();
        public event ReachedTopSpeedEventHandler ReachedTopSpeed;

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
            }
            OnReachedTopSpeed();
        }

        private void OnReachedTopSpeed()
        {
            if (ReachedTopSpeed != null)
                ReachedTopSpeed();
        }
    }
}
