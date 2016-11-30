using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Factorial Calculator");
            bool answer = true;
           
            while (answer)
            {

                Console.WriteLine("Enter an integer that's greater than 0 but less than 10");
                int num01 = int.Parse(Console.ReadLine());
               
                Console.WriteLine("The factorial of " + num01 + " is " + Factoring (num01));

                
                Console.WriteLine("Do you want to continue? (y/n)");
                string con = Console.ReadLine();
                if (con == "y")

                { answer = true; }

                else {
                    answer = false;
                    Console.WriteLine("Thank you and Take care"); } 
                      
            }
            
            }
        //------------Methods------
        static long Factoring (int num01)
        {
            long factorial = 1;
            for (int i = 1; i <= num01; i++)

            {
                factorial = factorial * i;
                 
            }
           return factorial;
        }    
        }
    }

