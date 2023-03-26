using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Введите свое имя");
            
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine(sum);

            Console.ReadLine();
        }
    }
}


