using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter today's day of the week:");
            string getToday = Console.ReadLine();
            
            try
            {
                DaysOfTheWeek today = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek),getToday);
                Console.WriteLine("Today is " + today);
            }
            catch
            {
                Console.WriteLine("Please enter a day of the week.");
            }
            Console.ReadLine();
        }
        enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
