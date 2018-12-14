using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();

            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNumber);

            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
            string needsHelp = Console.ReadLine();
            bool needHelp = Convert.ToBoolean(needsHelp);

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string positiveExperience = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string extraFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            int studyHoursNum = Convert.ToInt32(studyHours);

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.Read();
        }
    }
}
