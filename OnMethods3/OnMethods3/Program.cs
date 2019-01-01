using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnMethods3
{
    class Program
    {
        static void Main(string[] args)
        {
            Mathy mathy = new Mathy();
            // method 1
            Console.WriteLine(mathy.Math1(12));
            //method 2
            Console.WriteLine(mathy.Math1(12.5f));
            // method3
            Console.Write("Please enter a number for math: ");
            Console.WriteLine(mathy.Math1(Console.ReadLine()));

            
            Console.ReadLine();
        }
    }
}
