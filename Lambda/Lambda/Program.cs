using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { FirstName = "Joe", LastName = "Smith", Id = 0 },
                new Employee() { FirstName = "Joe", LastName = "Jameson", Id = 1 },
                new Employee() { FirstName = "John", LastName = "Johnson", Id = 2 },
                new Employee() { FirstName = "Steven", LastName = "Williams", Id = 3 },
                new Employee() { FirstName = "Amelia", LastName = "Jones", Id = 4 },
                new Employee() { FirstName = "Micheal", LastName = "Brown", Id = 5 },
                new Employee() { FirstName = "Miranda", LastName = "Davis", Id = 6 },
                new Employee() { FirstName = "Darren", LastName = "Miller", Id = 7 },
                new Employee() { FirstName = "Lisa", LastName = "Morgen", Id = 8 },
                new Employee() { FirstName = "Kevin", LastName = "Wilson", Id = 9 }
            };

            List<Employee> joeNames = new List<Employee>();

            foreach (Employee name in employees)
            {
                if (name.FirstName == "Joe")
                {
                    joeNames.Add(name);
                }
            }

            List<Employee>joeNames2 = employees.Where(x => x.FirstName == "Joe").ToList();

            List<Employee> Id5 = employees.Where(x => x.Id > 5 ).ToList();

            Console.ReadLine();
        }
    }
}
