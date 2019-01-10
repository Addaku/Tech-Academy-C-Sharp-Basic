using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your Current time is: " + DateTime.Now);
            Console.WriteLine("Please enter a number.");
            double getNum = Convert.ToDouble(Console.ReadLine());
            DateTime newDate = DateTime.Now;
            Console.WriteLine("In {0} hours it will be {1}",getNum, newDate.AddHours(getNum));

            Console.ReadLine();
        }
    }
}
