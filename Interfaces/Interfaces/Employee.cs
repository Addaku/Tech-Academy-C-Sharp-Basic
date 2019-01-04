using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public class Employee : Person, IQuittable
    {

        public int Id { get; set; }

        public void Quit()
        {
            Console.WriteLine("You Quit");
        }

        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }
        
    }
}