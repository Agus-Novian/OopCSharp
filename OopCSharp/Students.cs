using System;
using System.Collections.Generic;
using System.Text;

namespace OopCSharp
{
    // Base class
    public class Students
    {
        // Constructor
        public Students()
        {
            Console.WriteLine("Students class constructor");
        }
        public void StudentMethod()
        {
            Console.WriteLine("This property belong to student");
        }
    }

    // Derived class
    public class Child : Students
    {
        public Child() :
            base()
        {
            Console.WriteLine("Child class constructor");
        }

        public void ChildMethod()
        {
            Console.WriteLine("this property belong child");
        }
    }
}
