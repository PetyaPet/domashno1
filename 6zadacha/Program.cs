using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int count = 0;
            int num = number;
            int keeper = number;
            int sum = 1;
            int total = 0;

             while(num > 0)
             {
                count++;
                num /= 10;
             }

            for (int i = count; i > 0; i--)
             {
                int current = number % 10;
                number /= 10;

                for (int j = current; j > 0; j--)
                {
                    sum *= j;
                }
                total += sum;
                sum = 1;
            }
            if (total == keeper)
            {
                Console.WriteLine("ÿes");
            }
            else
            {
                Console.WriteLine("no");
            }
            Console.ReadKey();
        }
    }
}
