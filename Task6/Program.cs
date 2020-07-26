using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(ReadVar("a"));
            double b = Convert.ToDouble(ReadVar("b"));
            string name = ReadVar("имя");
            Console.WriteLine($"{a}, {b}, {name}");
            Pause();
        }
        static string ReadVar(string str)
        {
            Console.WriteLine($"Введите \"{str}\"");
            return Console.ReadLine();
        }
        static void Pause()
        {
            Console.ReadKey();
        }
    }
}
