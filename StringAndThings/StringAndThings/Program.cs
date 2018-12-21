using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndThings
{
    class Program
    {
        static void Main(string[] args)
        {
            string partOne = "First Comes this, ";
            string partTwo = "and this comes second, ";
            string partThree = "this is last.";

            Console.WriteLine(partOne + partTwo + partThree);

            string upString = "Converted to upcase.";
            upString = upString.ToUpper();

            Console.WriteLine(upString);

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("How many sentances in a paragraph?");
            sb.AppendLine("Three I think.");
            sb.AppendLine("Thats good.");
            Console.WriteLine(sb);

            Console.Read();
        }
    }
}
