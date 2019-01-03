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
            Employee person = new Employee()
            {
                FirstName = "Sample",
                LastName = "Student"

            };
            person.Sayname();

            IQuittable quit = new Employee();
            quit.Quit();
            
            Console.ReadLine();
        }
    }
}
