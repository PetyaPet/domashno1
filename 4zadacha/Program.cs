using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            int beginning = int.Parse(Console.ReadLine());
            int ending = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = beginning; i <= ending; i++)
            {
                if(i == ending)
                {
                    Console.WriteLine($"{i} ");
                    sum += i;
                    break;
                }
                Console.Write($"{i} ");
                sum += i;
            }

            Console.WriteLine($"Sum: {sum}");
            Console.ReadKey();
        }
    }
}
