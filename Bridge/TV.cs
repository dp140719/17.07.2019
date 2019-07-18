using System;
namespace Bridge
{
    public class TV : EntertainmentDevice
    {
        public TV(int max, bool isOn)
        {
            this.State = 1;
            this.Max = max;
            this.IsOn = isOn;
        }

        public override void PressNext()
        {
            this.State++;
            if (State > Max)
            {
                State = 1;
                Console.Write("Channel max reached...");
            }
            Console.WriteLine($"Changed to {State} channel");
        }

        public override void PressPrevious()
        {
            this.State--;
            if (this.State == 0)
            {
                this.State = Max;
            }
            Console.WriteLine($"Changed to {State} channel");
        }

        public override void PrintStatus()
        {
            Console.WriteLine($"Current state is: {IsOn} and the channel is: {State}");
        }
    }
}
