using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number.");
            string number1 = Console.ReadLine();
            int num1 = Convert.ToInt32(number1);
            int total1 = 50 * num1;
            Console.WriteLine("Your number multiplied by 50 = " + total1);
            Console.Read();

            Console.WriteLine("Enter a Number.");
            string number2 = Console.ReadLine();
            int num2 = Convert.ToInt32(number2);
            int total2 = 25 + num2;
            Console.WriteLine("Your number plus 25 = " + total2);
            Console.Read();

            Console.WriteLine("Enter a Number.");
            string number3 = Console.ReadLine();
            double num3 = Convert.ToDouble(number3);
            double total3 = num3 / 12.5;
            Console.WriteLine("Your number divided by 12.5 = " + total3);
            Console.Read();

            Console.WriteLine("Enter a Number.");
            string number4 = Console.ReadLine();
            int num4 = Convert.ToInt32(number4);
            bool total4 = num4 > 50;
            Console.WriteLine("Is your number greater than 50? " + total4);
            Console.Read();

            Console.WriteLine("Enter a Number.");
            string number5 = Console.ReadLine();
            double num5 = Convert.ToDouble(number5);
            double total5 = num5 % 7;
            Console.WriteLine("Your number divided by 7. Remainder = " + total5);
            Console.Read();
        }
    }
}
