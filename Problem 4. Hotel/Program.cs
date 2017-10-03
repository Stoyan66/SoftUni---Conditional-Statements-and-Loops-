using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());

            decimal discount = 1;

            if (month == "May")
            {
                if (nights > 7)
                {
                    discount = 0.95m;
                    Console.WriteLine("Studio: {0:f2} lv.", nights * 50 * discount);
                }
                else
                {
                    Console.WriteLine("Studio: {0:f2} lv.", nights * 50);
                }
                Console.WriteLine("Double: {0:f2} lv.", nights * 65);
                Console.WriteLine("Suite: {0:f2} lv.", nights * 75);
            }
            else if (month == "October")
            {
                if (nights > 7)
                {
                    discount = 0.95m;
                    Console.WriteLine("Studio: {0:f2} lv.", (nights - 1) * 50 * discount);
                }
                else
                {
                    Console.WriteLine("Studio: {0:f2} lv.", nights * 50);
                }
                Console.WriteLine("Double: {0:f2} lv.", nights * 65);
                Console.WriteLine("Suite: {0:f2} lv.", nights * 75);
            }
            else if (month == "June")
            {

                if (nights > 14)
                {
                    discount = 0.90m;
                    Console.WriteLine("Studio: {0:f2} lv.", nights * 60);
                    Console.WriteLine("Double: {0:f2} lv.", nights * discount * 72);
                    Console.WriteLine("Suite: {0:f2} lv.", nights * 82);

                }
                else
                {
                    Console.WriteLine("Studio: {0:f2} lv.", nights * 60);
                    Console.WriteLine("Double: {0:f2} lv.", nights * 72);
                    Console.WriteLine("Suite: {0:f2} lv.", nights * 82);
                }
            }
            else if (month == "September")
            {
                if (nights > 14)
                {
                    Console.WriteLine("Studio: {0:f2} lv.", (nights - 1) * 60);
                    discount = 0.90m;
                }
                else if (nights > 7 && nights <= 14)
                {
                    Console.WriteLine("Studio: {0:f2} lv.", (nights - 1) * 60);
                }
                else
                {
                    Console.WriteLine("Studio: {0:f2} lv.", nights * 60);
                }
                Console.WriteLine("Double: {0:f2} lv.", nights * discount * 72);
                Console.WriteLine("Suite: {0:f2} lv.", nights * 82);
            }
            else
            {
                Console.WriteLine("Studio: {0:f2} lv.", nights * 68);
                Console.WriteLine("Double: {0:f2} lv.", nights * 77);

                if (nights > 14)
                {
                    discount = 0.85m;
                }
                Console.WriteLine("Suite: {0:f2} lv.", nights * discount * 89);
            }
        }
    }
}