using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите вес:");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите рост в сантиметрах:");
            double height = Convert.ToDouble(Console.ReadLine()) / 100;
            double index = weight / Math.Pow(height, 2);
            Console.WriteLine($"Индекс массы тела равен {index}. Питайтесь правильно!");
            Console.ReadKey();

        }
    }
}
