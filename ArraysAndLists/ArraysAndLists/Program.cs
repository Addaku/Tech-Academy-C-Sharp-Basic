using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = new string[3];
            stringArray[0] = "Is this the string you wanted?";
            stringArray[1] = "You chose this string? Really?";
            stringArray[2] = "Was this string the right choice? Probably.";
            Console.WriteLine("Please enter 0, 1, or 2 to receive a random sentence.");
            int stringNum = Convert.ToInt32(Console.ReadLine());

            if ((stringNum >= 2) && (stringNum <= 0))
            {
                Console.WriteLine(stringArray[stringNum]);
            }
            else
            {
                Console.WriteLine("You entered the wrong number, but you still got a string.");
            }
            Console.ReadLine();

            int[] intArray = new int[] { 27, 14, 84, 36, 77 };
            Console.WriteLine("Please enter a number between 0 and 4 to receive a random number.");
            int intNum = Convert.ToInt32(Console.ReadLine());

            if ((intNum >= 0) && (intNum <= 4))
            {
                Console.WriteLine(intArray[intNum]);
            }
            else
            {
                Console.WriteLine("You enter something incorrectly so no numbers for you...");
            }

            List<string> stringList = new List<string>();
            stringList.Add("string 1");
            stringList.Add("string 2");
            stringList.Add("string 3");
            Console.WriteLine("Enter a number between 0 and 2.");
            int listNum = Convert.ToInt32(Console.ReadLine());
            if ((listNum == 0) || (listNum == 1) || (listNum == 2))
            {
                Console.WriteLine(stringList[listNum]);
            }
            else
            {
                Console.WriteLine("Something went horribly wrong.");
            }

            Console.Read();
        }
    }
}
