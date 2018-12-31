using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to math on.");
            int getNum = Convert.ToInt32(Console.ReadLine());
            int drawNum = 0;

            drawNum = Math.Math1(getNum);
            Console.WriteLine(drawNum);

            drawNum = Math.Math2(getNum);
            Console.WriteLine(drawNum);

            drawNum = Math.Math3(getNum);
            Console.WriteLine(drawNum);

            Console.ReadLine();
        }
    }
}
