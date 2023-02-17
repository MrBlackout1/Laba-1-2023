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
            Console.Write("Input count of nums: ");
            int count = Convert.ToInt32(Console.ReadLine());
            List<GetNumber> delegates = new List<GetNumber>();
            Random r = new Random();
            for (int i = 0; i < count; i++)
                delegates.Add(() => r.Next(10));
            Console.WriteLine($"Avegate result: { Average(delegates) }");
        }
        static double Average(List<GetNumber> delegates)
        {
            double sum = 0;
            Console.WriteLine("Values:");
            Console.WriteLine("--------------------");
            foreach (var del in delegates)
            {
                int value = del();
                Console.WriteLine(value);
                sum += value;
            }
            Console.WriteLine("--------------------");
            return sum / delegates.Count();
        }
    }
}