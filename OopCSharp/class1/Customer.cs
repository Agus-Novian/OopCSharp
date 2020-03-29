using System;
using System.Collections.Generic;
using System.Text;

namespace OopCSharp
{
    class Customer
    {
        // Member variables
        public int CustID;
        public string Name;
        public string Gender;
        public string Address;
        public string NoPhone;

        // Constructor for initializing fields
        public Customer()
        {
            CustID = 001;
            Name = "Agus Novian";
            Gender = "Male";
            Address = "Indoneia";
            NoPhone = "+6281575541255";
        }

        // Method for displaying customer records (functionality)
        public void displayData()
        {
            Console.WriteLine("Customer = " + CustID);
            Console.WriteLine("Name = " + Name);
            Console.WriteLine("Gender = " + Gender);
            Console.WriteLine("Address = " + Address);
            Console.WriteLine("No. Phone = " + NoPhone + "\n");
        }
    }
}
