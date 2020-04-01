using System;
using System.Collections.Generic;
using System.Text;

namespace OopCSharp.overloading
{
    class funcOverloading
    {
        public string name;

        // Overloaded function
        public void setName(string last)
        {
            name = last;
            Console.WriteLine(name);
        }

        public void setName(string first, string last)
        {
            name = first + " " + last;
            Console.WriteLine(name);
        }

        public void setName(string first, string middle, string last)
        {
            name = first + " " + middle + " " + last;
            Console.WriteLine(name);
        }
    }
}
