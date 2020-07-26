using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 5;
            Console.WriteLine($"a={a}, b={b}");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"А теперь a={a}, а b={b}");
        }
    }
}
