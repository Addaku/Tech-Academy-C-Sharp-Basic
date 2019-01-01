using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Mathy mathy = new Mathy();

            Console.WriteLine("How many numbers do you wish to enter? 1 or 2?");
            int getNum1 = Convert.ToInt32(Console.ReadLine());


            if (getNum1 == 1)
            {
                Console.WriteLine("Number 1:");
                int getNum2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(mathy.Math1(getNum2));
            }
            else if (getNum1 == 2)
            {
                Console.WriteLine("Number 1:");
                int getNum2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Number 2:");
                int getNum3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(mathy.Math1(getNum2,getNum3));

            }
            else
            {
                Console.WriteLine("You've entered something wrong.");
            }
            Console.ReadLine();
        }
    }
}
