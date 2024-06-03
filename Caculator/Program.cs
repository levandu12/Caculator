using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculator calculator = new Calculator();
            Console.WriteLine("INput a");
            float a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("INput b");
            float b = Int32.Parse(Console.ReadLine());
            Calculator ca = new Calculator();
            Console.WriteLine(ca.Multiple(a, b));

        }
    }
}
