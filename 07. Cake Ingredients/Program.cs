using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingre = String.Empty;

            for (int i = 0; i <= 20; i++)
            {
                ingre = Console.ReadLine();

                if (ingre != "Bake!")
                {
                    Console.WriteLine($"Adding ingredient {ingre}.");
                }
                else
                {
                    Console.WriteLine($"Preparing cake with {i} ingredients.");
                    break;
                }
            }
            
        }
    }



           
           
           

          


           







        }