using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в анкету!");
            Console.WriteLine("Введите ваше имя:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ваш рост в сантиметрах:");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ваш вес:");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Итак, вас зовут {firstName} {lastName}, вам {age} лет, ваш рост {height} сантиметров, и вы весите {weight} килограммов \nБольшое спасибо за опрос!");
            Console.ReadKey();
        }
    }
}
