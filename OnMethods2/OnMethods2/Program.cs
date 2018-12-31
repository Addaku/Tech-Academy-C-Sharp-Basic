using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnMethods2
{
    class Program
    {
        static void Main(string[] args)
        {
            Mathy mathy = new Mathy();

            Mathy.Math1(1,2);
            Mathy.Math1(Num2: 30, Num1: 4);
            Console.ReadLine();
        }
    }
}
