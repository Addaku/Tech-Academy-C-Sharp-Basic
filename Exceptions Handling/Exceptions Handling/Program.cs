using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> integerList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                Console.WriteLine("Please enter a number.");
                int numSelected = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Rounded quotients:");
                foreach (int num in integerList)
                {
                    int quotient = num / numSelected;
                    Console.WriteLine(quotient);
                }
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error. Please enter a whole number.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error. Do not divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("End of try/catch block");
            Console.ReadLine();
        }
    }
}
