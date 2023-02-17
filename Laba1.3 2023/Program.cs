using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        public delegate double Calculate(double a, double b);
        public delegate int GetNumber();
        public static void Main()
        {
            Console.Write("Input number a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Input number b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Input number c:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Average result: { Average(a, b, c) }");
        }
        static double Average(int a, int b, int c) => (a + b + c) / 3;
    }
}