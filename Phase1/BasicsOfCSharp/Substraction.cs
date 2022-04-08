using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfCSharp
{
    internal class Substraction
    {
        public void Do()
        {
            Console.WriteLine("Enter the 1st value ");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter the 2nd value ");
            string s2 = Console.ReadLine();
            Double a1 = Convert.ToDouble(s1);
            Double a2 = Convert.ToDouble(s2);
            double a3 = a1 - a2;
            Console.WriteLine(a3);
        }
    }
}
