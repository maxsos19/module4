using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
			var a = 6;
			var b = 7;
			

			if (a == b)
			{
				Console.WriteLine("Условие истинно");
			}
			else
			{
				Console.WriteLine("Условие ложно");
			}
			if (b < 10)
			{

				Console.WriteLine("Значение b={0} меньше 10", b);
			}
			else
			{
				Console.WriteLine("Значение b={0} больше 10", b);
			
			
			}
			Console.ReadKey();


		}		
    }
}
