using System;
using System.Collections.Generic;
using System.Text;

namespace OopCSharp
{
    static class StaticClass
    {
        // Static fields
        static int x = 100, y;

        // Static method
        public static void calcute()
        {
            y = x * x;
            Console.WriteLine(y);
        }
    }
}
