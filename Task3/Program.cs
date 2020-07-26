using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приветствуем вас на локальном подсчете дистанции!");
            Console.WriteLine("Введите координаты первой точки:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты второй точки:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double d = countDistance(x1, x2, y1, y2);
            Console.WriteLine($"Итак, расстояние равно {d:F2}");
            Console.ReadKey();
        }

        static double countDistance(double _x1, double _x2, double _y1, double _y2)
        {
            return Math.Sqrt(Math.Pow(_x2-_x1,2) + Math.Pow(_y2-_y1,2));
        }
    }
}
