using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numberGenerator = new Random();
            
            Console.WriteLine("Welcome to the Grand Circus Casino!\n Press any key to Continue");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Would you like to roll the Dice?  (y/n)");
            string con = Console.ReadLine();
            if (con == "y")
                
                {
                Start:
                    Console.WriteLine("How many sides would you like your dice to have?");
                    int diceNum = Convert.ToInt32(Console.ReadLine());

                    int num1 = numberGenerator.Next(1, diceNum);
                    int num02 = numberGenerator.Next(1, diceNum);

                    Console.WriteLine("1st Dice = " + num1);
                    Console.WriteLine("2nd Dice = " + num02);
                    Console.WriteLine("\n\n");

                    Console.WriteLine("Would you like to roll again?  (y/n)");
                    string cont2 = Console.ReadLine();
                    if (cont2 == "y") { goto Start;}

                    else { Console.WriteLine("\n\nThank You for Rolling! Good-Bye.\n\n"); }
                }
            else { Console.WriteLine("\n\n Fine. Leave like a Loser then!!!");}
         }        
    }

}
    
