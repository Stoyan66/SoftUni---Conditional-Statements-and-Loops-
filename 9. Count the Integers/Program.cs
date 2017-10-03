using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)

        {
            var count  = 0;
            while (true)
            {
                try
                {
                    var n = int.Parse(Console.ReadLine());
                    count++;
                }
                catch (Exception)
                {

                   break;
                }
                

            }
            Console.WriteLine(count);
        }
    }
}














