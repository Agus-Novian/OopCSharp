using OopCSharp.class2;
using System;

namespace OopCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Object instantiation
            Customer customer = new Customer();

            Aritmatic aritmatic = new Aritmatic();

            // Partial class instance
            partialClass pClass = new partialClass();

            // Constructor class instance
            Employe employe = new Employe(20, "Agus", "Novian", "Indonesia", "Programmer");

            // Destructor class instance
            EmployeDestructors employeDestructors = new EmployeDestructors();

            // Method
            customer.displayData(); // Customer
            
            aritmatic.Additional(); // Aritmatic

            pClass.method1(); // partial1
            pClass.method2(); // partial2

            StaticClass.calcute(); // static class

            // Constructor
            employe.AppendData(); // constructor
            Employe.getData(); // static constructor

            // Destructor
            employeDestructors.getData();

        }
    }

    class Aritmatic
    {
        // Variables
        int x = 100;
        int y = 200;
        int z;

        // Method
        public void Additional()
        {
            z = x + y;
            Console.WriteLine("Other class in Namespace");
            Console.WriteLine(z);
        }
    }
}
