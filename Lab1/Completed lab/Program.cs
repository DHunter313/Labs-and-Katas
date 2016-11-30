using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Completed_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Continue = true;
            do
            {

                Console.WriteLine("Welcome to Grand Circus' Room Detail Generator");
                Console.WriteLine();
                Console.WriteLine("Enter Length");
                string length = Console.ReadLine();
                double Value1 = double.Parse(length);
                Console.WriteLine("Enter Width");
                string width = Console.ReadLine();
                double Value2 = double.Parse(width);

                Console.WriteLine("Area:");
                double Area = Value1 * Value2;
                Console.WriteLine(Area);
                Console.WriteLine("Perimeter");
                double Perimeter = 2 * (Value1 * Value2);
                Console.WriteLine(Perimeter);
                Console.WriteLine();
                Console.WriteLine("Continue (y/n)");
                string response = Console.ReadLine();
                Continue = response == "y";
            } while (Continue);




        }
    }
}
