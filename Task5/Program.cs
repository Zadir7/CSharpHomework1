using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Print("Александр","Бондарев","Барнаул");
            Pause();
        }
        static void Print(string _firstName, string _lastName, string _city)
        {
            Console.CursorTop = Console.WindowHeight / 2;
            string str = $"Меня зовут {_firstName} {_lastName}, я живу в городе {_city}";
            Console.CursorLeft = (Console.WindowWidth - str.Length) / 2;
            Console.WriteLine(str);
        }
        static void Pause()
        {
            Console.ReadKey();
        }
    }
}
