using System;
using System.Collections.Generic;
using System.Text;

namespace OopCSharp
{
    // Base class
    public class Students
    {
        public void StudentMethod()
        {
            Console.WriteLine("Inheritance\nThis property belong to student");
        }
    }

    // Derived class
    public class Child : Students
    {
        public void ChildMethod()
        {
            Console.WriteLine("this property belong child");
        }
    }
}
