using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfCSharp
{
    internal class Addition
    {//instance method
        public void Do()
        {
            Console.WriteLine("Enter the 1st value");
            string s1 = Console.ReadLine();
            int a = Convert.ToInt32(s1);
            Console.WriteLine("Enter the 2nd value");
            String s2 = Console.ReadLine();
            int b = Convert.ToInt32(s2);
            int c = a + b;
            Console.WriteLine(c);
        }
    }
}
