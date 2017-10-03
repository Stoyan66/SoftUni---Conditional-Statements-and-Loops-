using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var proffesion = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());


            if (proffesion == "Athlete")
            {
                var price = quantity * 0.70;
                Console.WriteLine($"The {proffesion} has to pay {price:f2}.");

            }
            else if (proffesion == "Businessman" || proffesion == "Businesswoman")
            {
                var price = quantity * 1;
                Console.WriteLine($"The {proffesion} has to pay {price:f2}.");

            }
            else if (proffesion == "SoftUni Student")
            {
           
                var price = quantity * 1.70;
                Console.WriteLine($"The {proffesion} has to pay {price:f2}.");

            }
            else
            {
                var price = quantity * 1.20;
                Console.WriteLine($"The {proffesion} has to pay {price:f2}.");

            }
            
        }
        }
    }

