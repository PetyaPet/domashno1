using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            int loseCount = int.Parse(Console.ReadLine());
            double headPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice= double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int seconds = loseCount / 2;
            int thirds = loseCount / 3;
            int both = loseCount / 6;
            int all = both / 2;

            double total = seconds * headPrice;
            total += thirds * mousePrice;
            total += both * keyboardPrice;
            total += all * displayPrice;

            Console.WriteLine($"Rage expenses: {total : 0.00}lv.");
            Console.ReadKey();
        }
    }
}
