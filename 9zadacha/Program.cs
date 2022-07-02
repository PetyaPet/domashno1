using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int jedi = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());
            int count = jedi;
            double moneyForLightsaber = Math.Ceiling(count * 1.10) * lightsaberPrice;
            count -= jedi / 6;
            double moneyForRobe = count * robePrice;
            double  moneyForBelt = jedi * beltPrice;

            double total = moneyForLightsaber + moneyForBelt + moneyForRobe;
            if (money >= total)
            {
                Console.WriteLine($"The money is enough - it would cost {total:0.00}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {total - money: 0.00}lv more");
            }
            Console.ReadKey();
        }

    }
}
