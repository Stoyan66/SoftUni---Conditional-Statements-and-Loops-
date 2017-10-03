using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            int boundary = int.Parse(Console.ReadLine());

            var combinations = 0;
            double result = 0.0;

            for (int i = a; i >= 1; i--)
            {
                for (int c = 1; c <= b; c++)
                {
                    if (result >= boundary)
                    {
                        break;
                    }
                    result += (i * c) * 3;
                    combinations++;
                }

            }
            if (result >= boundary)
            {
                Console.WriteLine($"{combinations} combinations");
                Console.WriteLine($"Sum: {result} >= {boundary}");
            }
            else
            {
                Console.WriteLine($"{combinations} combinations");
                Console.WriteLine($"Sum: {result}");
            }

          
               
                    
                }
            }
        }

    

