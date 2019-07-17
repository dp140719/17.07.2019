using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintSequense("ANNNAAAAAOOOONNNAAAAAAAAA");
        }

        static void PrintSequense(string seq)
        {
            foreach(char c in seq)
            {

                for (int i = 0; i < VeryHeavyObject.MAX_SIZE; i++)
                {
                    Console.WriteLine(FlyWeightFactory.GetHeavyObjects(c)[i]);
                }
            }
        }
    }
}
