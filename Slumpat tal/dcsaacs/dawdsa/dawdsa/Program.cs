﻿using System;
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
            int rng = rd.Next(1,100);

            Console.WriteLine("Gissa vilket tal mellan 1 och 100");
            int tal= int.Parse(Console.ReadLine());
            
            while (tal != rng)
            {
                Console.Writeline("Fel");
                int tal= int.Parse(Console.ReadLine());
                
                if (tal < rng)
                    Console.Writeline("Fel"); // För lågt
                    
                if (tal > rng)
                    Console.Writeline("Fel"); //För mycket
            }
            Console.Writeline("Rätt");
        }
    }
}
