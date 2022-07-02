using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0.00;
            string command = Console.ReadLine();

          while(command != "Start")
            {
                double current = double.Parse(command);
                if(current == 0.1 || current == 0.2 || current == 0.5 || current == 1 || current == 2)
                {
                    sum += current;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {current}");
                }
                command = Console.ReadLine();
            }
            command = Console.ReadLine();
            double price = 0.00;

            while(command != "End")
            {
                if(command == "Nuts" || command == "Water" || command == "Crisps" || command == "Soda" || command == "Coke" )
                {
                    if (command == "Nuts")
                    {
                        price += 2.00;
                    }
                    if (command == "Water")
                    {
                        price += 0.70;
                    }
                    if (command == "Crisps")
                    {
                        price += 1.50;
                    }
                    if (command == "Soda")
                    {
                        price += 0.80;
                    }
                    if (command == "Coke")
                    {
                        price += 1.00;
                    }
                    if (price > sum)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine($"Purchased {command}");
                        sum -= price;
                        Math.Round(sum, 2);
                    }
                    
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                price = 0.00;
                command = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sum: 0.00}");
            Console.ReadKey();
        }
    }
}
