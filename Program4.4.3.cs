using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            var (name, age) = ("Максим", 19);
            
            Console.WriteLine("Ваше имя: {0}", name);
            Console.WriteLine("Ваш возраст: {0}", age);

            Console.WriteLine("Введите ваше имя: ");
             name = Console.ReadLine();
            Console.WriteLine("Введите возраст с цифрами: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", name);
            Console.WriteLine("Ваш возраст: {0}", age);


            Console.ReadKey();
        }
    }
}
