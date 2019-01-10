using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            const string name = "Adrean";
            Console.WriteLine("Hello, my name is {0}",name);
            //2
            var myNum = 14;
            Console.WriteLine("My favorite number is {0}", myNum);
            //3
            Console.WriteLine("Please enter a name.");
            string getName = Console.ReadLine();
            Console.WriteLine("Please enter a number over 100.");
            int getNum = Convert.ToInt32(Console.ReadLine());
            Bank bank = new Bank(getName, getNum);
            Console.WriteLine("{0}'s account has ${1} in it.", bank.User, bank.Balance);

            Console.ReadLine();
        }
    }
}
