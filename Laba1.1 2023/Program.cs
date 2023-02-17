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
            while (true)
            {
                Console.Write("Input +, -, *, /:");
                char operatorSymbol = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Input number a:");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Input number b:");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                switch (operatorSymbol)
                {
                    case '+':
                        Calculate plus = (num1, num2) => num1 + num2;
                        Console.WriteLine($"Result: { plus(a, b) }");
                        break;
                    case '-':
                        Calculate minus = (num1, num2) => num1 - num2;
                        Console.WriteLine($"Result: { minus(a, b) }");
                        break;
                    case '*':
                        Calculate mul = (num1, num2) => num1 * num2;
                        Console.WriteLine($"Result: { mul(a, b) }");
                        break;
                    case '/':
                        Calculate div = (num1, num2) => num2 == 0 ? 0 : num1 / num2;
                        Console.WriteLine($"Result: { div(a, b) }");
                        break;
                    default:
                        return;
                }
            }
        }
    }
}