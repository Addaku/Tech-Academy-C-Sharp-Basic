using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public class Employee : Person
    {
        public override void Sayname()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }
    }
}
