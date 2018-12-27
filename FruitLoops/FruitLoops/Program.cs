using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray1 = { "word1 ", "word2 ", "word3 " };
            Console.WriteLine("Enter a word.");
            string word = Console.ReadLine();

            for (int i = 0; i < stringArray1.Length; i++)
            {
                stringArray1[i] = (stringArray1[i] + word);
                Console.WriteLine(stringArray1[i]);
            }

            Console.ReadLine();

            int LoopNum = 0;
            bool BoolLoop = true;
            while (BoolLoop)
            {
                LoopNum++;
                Console.WriteLine(LoopNum);
                if (LoopNum == 100)
                {
                    BoolLoop = false;
                }
            }
            Console.ReadLine();

            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine("Hello ");
            }

            Console.ReadLine();

            for (int k = 0; k <= 5; k++)
            {
                Console.WriteLine("Mello ");
            }

            Console.ReadLine();

            List<string> Index = new List<string>
            {
                "Sentence one.",
                "This is the second sentence.",
                "The Final sentence is the third."
            };

            Console.WriteLine("Search for a word: ");
            string wordSearch = Console.ReadLine();
            int check = 0;

            foreach (string wordFound in Index)
            {
                if (wordFound.Contains(wordSearch))
                {
                    check++;
                    Console.WriteLine(wordFound);
                    break;
                }
            }
            if (check == 0)
            {
                Console.WriteLine("Results not found.");
            }


            Console.ReadLine();

            List<string> twinList = new List<string>
            {
                "Unique string",
                "Common string",
                "Common string"
            };

            Console.WriteLine("Search for a word: ");
            string wordSearched = Console.ReadLine();
            int check1 = 0;
            
            foreach (string twin in twinList)
            {
                int twins = 0;
                foreach (string twinString in twinList)
                {
                    if (twin == twinString)
                    {
                        twins++;
                    }
                }
                if (twins > 1)
                {
                    Console.WriteLine(twin);
                }
            }

            foreach (string words in twinList)
            {
                if (words.Contains(wordSearched))
                {
                    check1++;
                }
            }
            if (check1 == 0)
            {
                Console.WriteLine("Results not found.");
            }
            Console.ReadLine();

            List<string> duped = new List<string>
            {
                "one",
                "two",
                "two",
                "three"
            };
            

            foreach (string dupe in duped)
            {
                int duplicate = 0;
                foreach( string doop in duped)
                {
                    if (dupe == doop)
                    {
                        duplicate++;
                    }
                }
                if (duplicate > 1)
                {
                    duplicate -= 1;
                    Console.WriteLine(dupe + ": has " + duplicate + " other ocurrence");
                }
                else if (duplicate <= 1)
                {
                    Console.WriteLine(dupe);
                }
            }
            Console.ReadLine();
        }
    }
}