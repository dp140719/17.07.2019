using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            TV tv = new TV(3, true);
            Memir YesOrHot = new Memir(4, false);

            RemoteControl remote = new RemoteControl(tv);
            remote.Next();
            remote.Next();
            remote.Next();
            remote.Next();

            remote.SetDevice(YesOrHot);
            remote.Next();
            remote.Next();
            remote.Next();
            remote.Next();
            remote.Next();
            remote.Next();
            remote.Off();
        }
    }
}
