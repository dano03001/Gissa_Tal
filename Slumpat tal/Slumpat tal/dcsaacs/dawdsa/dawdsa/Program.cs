using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dawdsa
{
    class Program
    {
        static void Main(string[] args)
        {
            int tries = 0;
            Random rd = new Random();
            int rng = rd.Next(1,100);

            Console.WriteLine("Gissa vilket tal mellan 1 och 100");
            int tal = Convert.ToInt32(Console.ReadLine());
            tries++;

            while (tal != rng)
            {
                Console.WriteLine("Fel");

                if (tal < rng)
                {
                    Console.WriteLine("För lågt");
                    tal = int.Parse(Console.ReadLine());
                    }

                else if (tal > rng)
                {
                    Console.WriteLine("För Högt");
                    tal = int.Parse(Console.ReadLine());
                }

                 else
                 {
                    Console.WriteLine("Fel input");
                 }
            }
            Console.WriteLine("Rätt, talet är: " + rng);
            Console.WriteLine("Antal Försök: " + tries);
        }
    }
}
