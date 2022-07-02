using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string password = string.Empty;
            for (int i = userName.Length - 1; i > -1; i--)
            {
                password += userName[i];
            }
            for (int i = 0; i <= 5; i++)
            {
                string option = Console.ReadLine();
                if (i == 5)
                {
                    Console.WriteLine($"User{userName}blocked");
                    break;
                }
                else if (option != password)
                {
                    Console.WriteLine("Incorrect password. Try again");
                }
                else if (option == password)
                {
                    Console.WriteLine($"User {userName} logged in.");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
