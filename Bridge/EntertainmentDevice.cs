using System;
namespace Bridge
{
    public abstract class EntertainmentDevice
    {
        public int State { get; set; }
        public int Max { get; set; }
        public bool IsOn { get; set; }

        public EntertainmentDevice()
        {
        }

        public abstract void PrintStatus();
        public abstract void PressNext();
        public abstract void PressPrevious();

        public void TurnOn()
        {
            Console.WriteLine($"Turning {this.GetType()} on...");
            this.IsOn = true;
        }

        public void TurnOff()
        {
            Console.WriteLine($"Turning {this.GetType()} off...");
            this.IsOn = false;
        }
    }
}
