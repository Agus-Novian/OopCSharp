using System;
using System.Collections.Generic;
using System.Text;

namespace OopCSharp.class2
{
    class EmployeDestructors
    {
        // Employe variables
        public int x, y;

        // Constructor for initializing fields
        public EmployeDestructors()
        {
            Console.WriteLine("Fields initialized");
        }

        // Method for get field
        public void getData()
        {
            y = x * x;
            Console.WriteLine("Destructor \n" + y);
        }

        // Method to release resource explicity
        public void Dispose()
        {
            Console.WriteLine("Fields cleaned");
            x = 0;
            y = 0;
        }

        // Destructor
        ~EmployeDestructors()
        {
            Dispose();
        }
    }
}
