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

            // Method calling
            customer.displayData();
            
            aritmatic.Additional();

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
