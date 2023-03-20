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
            int A = 1;
            int B = 2;
            double X = 3;
            double Y = 4;
            bool C = (A < B) | (X > Y);
            Console.WriteLine(C);
            Console.ReadKey();



        }
    }
}
