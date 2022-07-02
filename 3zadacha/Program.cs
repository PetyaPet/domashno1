using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double total = 0.00;

            if(type == "Students")
            {
                if(day == "Friday")
                {
                    total = amount * 8.45;
                }
                else if (day == "Saturday")
                {
                    total = amount * 9.8;
                }
                else 
                {
                    total = amount *10.46;
                }
                
                if (amount >= 30)
                {
                    total *= 0.85;
                }
            }
            else if (type == "Business")
            {
                if (day == "Friday")
                {
                    total = amount *10.9;
                    if (amount >= 100)
                    {
                        total -= 10 * 10.9;
                    }
                }
                else if (day == "Saturday")
                {
                    total = amount * 15.6;
                    if (amount >= 100)
                    {
                        total -= 10 * 15.6;
                    }
                }
                else
                {
                    total = amount * 16;
                    if (amount >= 100)
                    {
                        total -= 10 * 16;
                    }
                }
            }
            else 
            {
                if (day == "Friday")
                {
                    total = amount * 15;
                }
                else if (day == "Saturday")
                {
                    total = amount * 20;
                }
                else
                {
                    total = amount * 22.5;
                }

                if (amount > 9 && amount < 21)
                {
                    total *= 0.95;
                }
            }
            Console.WriteLine($"Total price: {Math.Round(total, 2)}");
            Console.ReadKey();
        }
    }
}
