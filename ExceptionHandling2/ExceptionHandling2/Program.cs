using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter your age.");
                int age = Convert.ToInt32(Console.ReadLine());
                DateTime DoB = DateTime.Now;
                if (age < 0)
                {
                    throw new NegativeException();
                }
                Console.WriteLine("Your date of birth is: " + DoB.AddYears(-age).ToString("yyyy"));
            }
            catch (NegativeException)
            {
                Console.WriteLine("You entered a negative number. You can't be negative years old!");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("uhh... something broke and I don't know what. Please contact the developer.");
                Console.ReadLine();
                return;
            }

            Console.ReadLine();
        }
    }
}
