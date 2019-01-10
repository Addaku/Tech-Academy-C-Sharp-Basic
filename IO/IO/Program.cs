using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            string getNum = Console.ReadLine();
            File.WriteAllText(@"C:\\Users\\Addak\\Test\\Test.txt", getNum);
            // way 1
            string textNum = File.ReadAllText(@"C:\\Users\\Addak\\Test\\Test.txt");
            Console.WriteLine("Your number was: " + textNum);
            // way 2
            Console.WriteLine(File.ReadAllText(@"C:\\Users\\Addak\\Test\\Test.txt"));

            Console.ReadLine();
        }
    }
}
