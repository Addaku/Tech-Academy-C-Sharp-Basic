using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Guess a number");
            //int numGuessed = Convert.ToInt32(Console.ReadLine());
            //bool isGuessed = false;

            //while (!isGuessed)
            //{
            //    switch(numGuessed)
            //    {
            //        case 10:
            //            Console.WriteLine("You Guessed 10. Thats too big. Try Again.");
            //            Console.WriteLine("Guess a number");
            //            numGuessed = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 7:
            //            Console.WriteLine("You Guessed 7. Thats Correct!");
            //            isGuessed = true;
            //            break;
            //        default:
            //            Console.WriteLine("You Guessed wrong. Try Again.");
            //            Console.WriteLine("Guess a number");
            //            numGuessed = Convert.ToInt32(Console.ReadLine());
            //            break;

            //    }
            //}
            //Console.Read();

            Console.WriteLine("Guess a number");
            int number = Convert.ToInt32(Console.ReadLine());
            bool DoIsGuessed = number == 14;

            do
            {
                switch (number)
                {
                    case 10:
                        Console.WriteLine("You Guessed 10. Thats too small.");
                        Console.WriteLine("Guess a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 14:
                        Console.WriteLine("You Guessed 14. Thats Correct!");
                        DoIsGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You Guessed wrong. Try again.");
                        Console.WriteLine("Guess a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            while (!DoIsGuessed);
            Console.Read();
        }
    }
}
