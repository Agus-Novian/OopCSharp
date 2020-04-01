using OopCSharp.class2;
using OopCSharp.overloading;
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

            // Overloading class instance
            funcOverloading funcOverloading = new funcOverloading();

            // Encapsulation class instance
            Encapsulation encapsulation = new Encapsulation(100);

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

            // Overloading
            funcOverloading.setName("\nAgus");
            funcOverloading.setName("Agus", "Novian");
            funcOverloading.setName("Agus", "Novian", "programming");

            // Encapsulation
            encapsulation.MySquere();

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
