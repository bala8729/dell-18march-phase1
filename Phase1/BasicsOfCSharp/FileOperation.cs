using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfCSharp
{//namespace is 
    internal class FileOperation
    {
        public void WriteFile()
        {
            string content = "Name, ID, Dept";
            File.WriteAllText("C://employee.txt", content);
        }
        public void UpdateFile()
        {
            string employee = "\nJonDoe, 1, Finance";
            File.AppendAllText("C://employee.txt", employee);

        }
        public void ReadFile()
        {
            string content = File.ReadAllText("C://employee.txt");
            Console.WriteLine(content);
            string[] contents = File.ReadAllLines("C://employee.txt");
        }
    }
}
