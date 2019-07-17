using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class RealATM : IATM
    {

        protected int totalCash;

        public void Desposit(int amount)
        {
            totalCash += amount;
        }

        public void EjectCard()
        {
            Console.WriteLine("Eject card.....");
        }

        public void InsertCard()
        {
            Console.WriteLine("I have a card in my stomach now");
        }

        public bool Withdraw(int amount)
        {

            if (amount < totalCash)
            {
                totalCash -= amount;
                return true;
            }

            return false;
        }

        public string GetStatus()
        {
            return "All good thumbs up!";
        }

        public int GetTotalCash()
        {
            return totalCash;
        }
    }
}
