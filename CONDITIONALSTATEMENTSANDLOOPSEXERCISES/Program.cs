﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONDITIONALSTATEMENTSANDLOOPSEXERCISES
{
    class Program
    {
        static void Main(string[] args)
        {
            var proffesion = Console.ReadLine();

            switch (proffesion)
            {
                case "Athlete": Console.WriteLine("Water"); break;
                case "Businessman": Console.WriteLine("Coffee"); break;
                case "Businesswoman": Console.WriteLine("Coffee"); break;
                case "SoftUni Student": Console.WriteLine("Beer"); break;
                default: Console.WriteLine("Tea"); break;

                    
            }
        }
    }
}
