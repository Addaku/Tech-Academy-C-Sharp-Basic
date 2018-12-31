using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnMethods
{
    public class Math
    {
        public static int Math1(int getNum)
        {
            int addNum = 10 + getNum;
            return addNum;
        }
        public static int Math2(int getNum)
        {
            int divideNum = getNum / 10;
            return divideNum;
        }
        public static int Math3(int getNum)
        {
            int multiplyNum = getNum * 10;
            return multiplyNum;
        }
    }
}
