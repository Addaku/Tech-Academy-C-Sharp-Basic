using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeatures
{
    class Bank
    {

        public Bank(string name) : this(name, 1000) { }
        public Bank(string name, int chosenNumber)
        {
            Balance = chosenNumber;
            User = name;
        }
        public int Balance { get; set; }
        public string User { get; set; }

    }
}
