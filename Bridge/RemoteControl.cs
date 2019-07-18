using System;
namespace Bridge
{
    public class RemoteControl
    {
        private EntertainmentDevice device;


        public RemoteControl(EntertainmentDevice device)
        {
            this.device = device;
        }

        public void SetDevice(EntertainmentDevice device)
        {
            this.device = device;
        }

        public void On()
        {
            this.device.TurnOn();
        }

        public void Off()
        {
            this.device.TurnOff();
        }

        public void Next()
        {
            this.device.PressNext();
        }

        public void Previous()
        {
            this.device.PressPrevious();
        }
    }
}
