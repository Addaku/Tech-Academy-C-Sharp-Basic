using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackagingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the weight of the package: ");
            string PackageWeight = Console.ReadLine();
            int PackageWeightNum = Convert.ToInt32(PackageWeight);
            if (PackageWeightNum <= 50)
            {
                Console.WriteLine("Please enter package width: ");
                string PackageWidth = Console.ReadLine();
                int PackageWidthNum = Convert.ToInt32(PackageWidth);
                Console.WriteLine("Please enter package height: ");
                string PackageHeight = Console.ReadLine();
                int PackageHeightNum = Convert.ToInt32(PackageHeight);
                Console.WriteLine("Please enter package length: ");
                string PackageLength = Console.ReadLine();
                int PackageLengthNum = Convert.ToInt32(PackageLength);
                int PackageSize = (PackageWidthNum + PackageHeightNum + PackageLengthNum);

                if (PackageSize <= 50)
                {
                    float PackageCost = ((PackageSize * PackageWeightNum) / 100);
                    Console.WriteLine("Your estimated total for shipping this package is: $" + (PackageCost) + " Thank You!");
                }
                else
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
            }
            else
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            Console.ReadLine();
        }
    }
}
