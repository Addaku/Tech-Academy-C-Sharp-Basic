using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly rate?"); 
            string person1rate = Console.ReadLine();
            Console.WriteLine("Hours worked per Week?");
            string person1hours = Console.ReadLine();

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly rate?");
            string person2rate = Console.ReadLine();
            Console.WriteLine("Hours worked per Week?");
            string person2hours = Console.ReadLine();

            int person1annual = Convert.ToInt32(person1rate) * (Convert.ToInt32(person1hours) * 52);
            Console.WriteLine("Person 1's Annual Salary = $" + person1annual);
            int person2annual = Convert.ToInt32(person2rate) * (Convert.ToInt32(person2hours) * 52);
            Console.WriteLine("Person 2's Annual Salary = $" + person2annual);
            
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool moneyCompare = person1annual > person2annual;
            Console.WriteLine(moneyCompare);
            Console.Read();
        }
    }
}
