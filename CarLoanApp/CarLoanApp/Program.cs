using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLoanApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Loan Application Survey");
            Console.WriteLine("What is you age?");
            string age = Console.ReadLine();
            int ageNum = Convert.ToInt32(age);
            Console.WriteLine("Have you ever had a DUI? Please enter 'true' or 'false'");
            string dui = Console.ReadLine();
            bool duiBool = Convert.ToBoolean(dui);
            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            int ticketsNum = Convert.ToInt32(tickets);
            Console.WriteLine("Loan Application Approved?");
            bool ageApproval = (ageNum > 15);
            bool ticketsApproval = (ticketsNum <= 3);
            bool duiApproval = (false == duiBool);
            Console.WriteLine(ageApproval && duiApproval && ticketsApproval);
            Console.Read();
        }
    }
}
