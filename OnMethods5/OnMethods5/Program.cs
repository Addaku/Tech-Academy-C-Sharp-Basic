using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnMethods5
{
    class Program
    {
        static void Main(string[] args)
        {
            Mathy mathy = new Mathy();
            mathy.Half(8);

            Console.Write("Enter a number: ");
            int getNum = Convert.ToInt32(Console.ReadLine());
            mathy.Half(getNum);

            mathy.Doubled(2, out int randNum);
            Console.WriteLine("Your randnum was: " + randNum);

            mathy.Half(12, 16);

            Console.ReadLine();
        }
        
    }
}
