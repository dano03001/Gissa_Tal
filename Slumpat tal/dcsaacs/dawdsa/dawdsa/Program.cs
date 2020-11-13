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
            Random rd = new Random();
            int rng = rd.Next(0, 101);

            Console.WriteLine("Gissa vilket tal mellan 1 och 100");
            int tal = Convert.ToInt32(Console.ReadLine());

            while (tal != rng)
            {
                Console.WriteLine("Fel");
                

                if (tal < rng)
                {
                    Console.WriteLine("För lågt");
                    tal = int.Parse(Console.ReadLine());
                }

                if (tal > rng)
                {
                    Console.WriteLine("För Högt");
                    tal = int.Parse(Console.ReadLine());
                }
            }
            
            Console.WriteLine("Rätt, talet är: " + rng);
        }
    }
}
