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

            (string Name, string Type, double age) Pet;

            Console.WriteLine("Введите имя вашего питомца");
            Pet.Name = Console.ReadLine();

            Console.WriteLine("Введите вид вашего жиовтного");
            Pet.Type = Console.ReadLine();


            Console.WriteLine("Введите возраст вашего животного");
            Pet.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n Имя вашего живтоного: {0}", Pet.Name);
            Console.WriteLine("\n Вид вашего животного: {0}", Pet.Type);
            Console.WriteLine("\n Возраст вашего животнного: {0}", Pet.age);
            Console.ReadLine();
            
           









        }
    }
}
