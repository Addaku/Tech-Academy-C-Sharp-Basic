using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnMethods5
{
    public class Mathy
    {
        public void Half (int num)
        {
            int num1 = num / 2;
            Console.WriteLine("{0} divided by 2 = {1}", num, num1);
        }

        public void Doubled(int num, out int randNum)
        {
            randNum = 6;
            int num1 = num * 2;
            Console.WriteLine("{0} multiplied by 2 = {1}", num, num1);
        }

        public void Half(int num, int num2)
        {
            int num1 = num / 2;
            int num3 = num2 / 2;
            Console.WriteLine("{0} divided by 2 = {1}", num, num1);
            Console.WriteLine("{0} divided by 2 = {1}", num2, num3);
        }
    }
}
