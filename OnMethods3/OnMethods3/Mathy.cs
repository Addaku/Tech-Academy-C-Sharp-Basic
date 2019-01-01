using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnMethods3
{
    public class Mathy
    {
        public int Math1(int num1)
        {
            num1 += 7;
            return num1;
        }
    
        public float Math1(float num1)
        {
            num1 += 5.5f;
            return num1;
        }
        public string Math1(string num1)
        {
            int num2 = Convert.ToInt32(num1);
            num2 -= 7;
            string num3 = Convert.ToString(num2);
            return num3;
        }
    }
}
