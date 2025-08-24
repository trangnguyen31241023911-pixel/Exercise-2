using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Ex01();
            //Ex02();
            Ex03();
        }
        static void Ex01()
        {
            Console.WriteLine("Nhap nhiet do: ");
            string C = Console.ReadLine();
            double number = 0;
            while (!double.TryParse(C, out number))
                Console.WriteLine("Xin vui long nhap so.");
            C = Console.ReadLine();
            double K = number + 273;
            double F = number * 18 / 10 + 32;
            Console.WriteLine($"Kelvin = {K} ");
            Console.WriteLine($"Fahrenhit = {F} ");
        }
        static void Ex02()
        {
            Console.WriteLine("Enter radius: ");
            string R = Console.ReadLine();
            double radius = 0;
            while (!double.TryParse(R, out radius))
            {
                Console.WriteLine("Xin vui long nhap so.");
                R = Console.ReadLine();
            }
            double surface = 4*Math.PI*Math.Pow(radius,2);
            double volume = 4/3* Math.PI * Math.Pow(radius, 3);
            Console.WriteLine($"Sphere with radius = {radius}:\n" +
                $"\tsurface = {surface}\n" +
                $"\tvolume = {volume}");
        }
        static void Ex03()
        {
            Console.WriteLine("Enter a: ");
            Console.WriteLine("Enter b: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} * {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {a / b}");
            Console.WriteLine($"{a} % {b} = {a % b}");
        }

    }
}
