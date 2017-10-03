using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {

            var ingrCount = int.Parse(Console.ReadLine());

            string ingr = String.Empty;

            var calls = 0;

            for (int i = 0; i < ingrCount; i++)
            {
                ingr = Console.ReadLine().ToLower();
                if (ingr == "cheese")
                {
                    calls = calls + 500;
                }
                if (ingr == "tomato sauce")
                {
                    calls = calls + 150;
                }
                if (ingr == "salami")
                {
                    calls = calls + 600;
                }
                if (ingr == "pepper")
                {
                    calls = calls + 50;
                }

            }
            Console.WriteLine("Total calories: " + calls);
        }
    }
}















            