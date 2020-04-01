using System;
using System.Collections.Generic;
using System.Text;

namespace OopCSharp.class2
{
    class Employe
    {
        // Variables
        public int EmpID;
        public string Name;
        public string Address;
        public string Devisi;

        // Static constructor
        static private int x;

        // Constructor for initializing fields
        public Employe(int empId, string fname, string lname, string address, string devisi)
        {
            EmpID = empId;
            Name = fname + " " + lname;
            Address = address;
            Devisi = devisi;
        }

        // Constructor for static initializing fields
        static Employe()
        {
            x = 100;
        }

        // Method for displaying employe records
        public void AppendData()
        {
            Console.WriteLine("\n" + EmpID.ToString());
            Console.WriteLine(Name);
            Console.WriteLine(Address);
            Console.WriteLine(Devisi);
        }

        // Method for get static field
        static public void getData()
        {
            Console.WriteLine("static constructor \n" + x);
        }
    }
}
