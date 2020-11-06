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

            int rand_num = rd.Next(1,100);

            Console.WriteLine("Gissa vilket tal mellan 1 och 100");
            int tal= int.Parse(Console.ReadLine());

            if (tal)
            {

            }
        }
    }
}
