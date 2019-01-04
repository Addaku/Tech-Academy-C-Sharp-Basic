using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperators
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee person1 = new Employee()
            {
                FirstName = "Sample",
                LastName = "Student"
            };

            person1.SayName();
            IQuittable quit = new Employee();
            quit.Quit();

            Console.ReadLine();
        }


    }
}