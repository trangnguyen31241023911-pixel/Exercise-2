using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Ex01();
            Ex02();
            Ex03();
            Ex04();
            Ex05();
        }
        //1.Write a C# Sharp program that takes two numbers as input and performs an operation (+,-,*,/,%) on them and displays the result of that operation.
        static void Ex01()
        {
            Console.WriteLine("Enter a: ");
            string inputa = Console.ReadLine();
            double a;
            while(!double.TryParse(inputa, out a))
            {
                Console.WriteLine("Invalid input, please enter number");
                inputa = Console.ReadLine();
            }
                
            Console.WriteLine("Enter b: ");
            string inputb = Console.ReadLine();
            double b;
            while (!double.TryParse(inputb, out b))
            {
                Console.WriteLine("Invalid input, please enter number");
                inputb = Console.ReadLine();
            }
            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} * {b} = {a * b}");
            if( b != 0)
            {
                Console.WriteLine($"{a} / {b} = {a / b}");
                Console.WriteLine($"{a} % {b} = {a % b}");
            }
            
        }
        /*2.Write a C# Sharp program to display certain values of the function
        x = y2 + 2y + 1 (using integer numbers for y, ranging from -5 to +5).
        */
        static void Ex02()
        {
            for( int y = -5; y <= 5; y++)
            {
                int x = y*y + 2*y +1;
                Console.WriteLine($"y = {y}, x = {x}");
            }
        }
        //3.Write a C# Sharp program that takes distance and time (hours, minutes, seconds) as input and displays speed in kilometers per hour (km/h) and miles per hour (miles/h).
        static void Ex03()
        {
            Console.WriteLine("Enter distance: ");
            double distance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter hours: ");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter minutes: ");
            int minutes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter seconds: ");
            int seconds = Convert.ToInt32(Console.ReadLine());

            double timehours = hours + (double)minutes / 60 + (double)seconds / 3600;
            if( hours != 0)
            {
                double speedKmh = distance / timehours;
                double speedMh = speedKmh * 0.6214;
                Console.WriteLine($"Speed: {speedKmh:F2} Km/h, {speedMh:F2} Miles/h");
            }

        }
        //4.Write a C# Sharp program that takes the radius of a sphere as input and calculates and displays the surface and volume of the sphere.  V = 4/3*π*r3 
        static void Ex04()
        {
            Console.WriteLine("Enter radius: ");
            double r = Convert.ToDouble(Console.ReadLine());
            double S = 4 * Math.PI * Math.Pow(r, 2);
            double V = 4/3 * Math.PI * Math.Pow(r, 3);
            Console.WriteLine($"Surface of sphere: {S}");
            Console.WriteLine($"Volume of sphere: {V}");
        }
        //5.Write a C# Sharp program that takes a character as input and checks if it is a vowel, a digit, or any other symbol. 
        static void Ex05()
        {
            Console.WriteLine("Enter a character: ");
            char c = Console.ReadKey().KeyChar;

            if("aoeuiAOEUI".IndexOf(c) >= 0)
                Console.WriteLine(" is a vowel");
            else if(char.IsDigit(c))
                Console.WriteLine(" is a digit");
            else if( char.IsLetter(c))
                Console.WriteLine(" is a letter");
            else
                Console.WriteLine(" is other symbol");
        }
    };

}
