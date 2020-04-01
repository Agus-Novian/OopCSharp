using System;
using System.Collections.Generic;
using System.Text;

namespace OopCSharp
{
    class Encapsulation
    {
        ///<summary>
        /// Every member Variable and Function of the class are bind    
        /// with the Encapsulation class object only and safe with     
        /// the outside inference 
        ///</summary>

        // Encapsulation begin
        int x;

        // Class constructor
        public Encapsulation(int ix)
        {
            this.x = ix;
        }

        // Calculating the squere
        public void MySquere()
        {
            int Calc = x * x;
            Console.WriteLine("\nEncapsulation\n" + Calc + "\n");
        }

        // End of encapsulation
    }
}
