using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> strings = new Employee<string>
            {
                Things = new List<string>() { "one", "two", "three" }
            };

            Employee<int> intergers = new Employee<int>
            {
                Things = new List<int>() { 1, 2, 3 }
            };

            foreach (string thing in strings.Things)
            {
                Console.WriteLine(thing);
            }

            foreach (int thing in intergers.Things)
            {
                Console.WriteLine(thing);
            }

            Employee<string> person1 = new Employee<string>()
            {
                FirstName = "Sample",
                LastName = "Student"
            };



            person1.SayName();
            IQuittable quit = new Employee<string>();
            quit.Quit();

            Console.ReadLine();
        }


    }
}