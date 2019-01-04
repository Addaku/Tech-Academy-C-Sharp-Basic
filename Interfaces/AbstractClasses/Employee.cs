using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public class Employee<T> : Person, IQuittable
    {

        public int Id { get; set; }
        public List<T> Things { get; set; }

        public void Quit()
        {
            Console.WriteLine("You Quit");
        }

        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }

        public static bool operator ==(Employee<T> employee1, Employee<T> employee2)
        {
            bool dupe = (employee1.Id == employee2.Id);
            return dupe;
        }

        public static bool operator !=(Employee<T> employee1, Employee<T> employee2)
        {
            bool dupe = (employee1.Id != employee2.Id);
            return dupe;
        }
    }
}
