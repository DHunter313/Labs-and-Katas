using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static string keepGoing;

        static void Main(string[] args)

        {
            Console.WriteLine("Welcome to Batting Average Calculator!"); do

            {
                Console.WriteLine("\nEnter number of times at bat: "); int batNum = int.Parse(Console.ReadLine()); int[] battingSheet = new int[batNum];               //int iCount=0;

                for (int iCount = 0; iCount < batNum; iCount++)

                {
                    Console.WriteLine("\n0=out, 1=single, 2=double, 3=triple, 4=home run");

                    Console.Write("Result for at-bat " + iCount + ": ");

                    battingSheet[iCount] = int.Parse(Console.ReadLine());

                }               
                Console.WriteLine("Slugging average: " + CalculateSluggingAverage(battingSheet) + "\n");

                continueOrQuit();

            } while (keepGoing.ToLower() == "y" || keepGoing.ToLower() == "yes");

        }
        public static double CalculateBattingAverage(int[] battingSheet)

        {
            int hit = 0; for (int i = 0; i < battingSheet.Length; i++)

            {
                // battingSheet[index] = 0;               if (battingSheet[i] > 0)

                {

                    hit = hit + 1;

                }

            }



            return (double)hit / battingSheet.Length;
        }
        public static double CalculateSluggingAverage(int[] battingSheet)
        {
            int sum = 0; for (int i = 0; i < battingSheet.Length; i++)
            {
                sum += battingSheet[i];
            }
            return (double)sum / battingSheet.Length;
        }
        private static void continueOrQuit()

        {

            Console.WriteLine("Another batter? (y/n)");

            keepGoing = Console.ReadLine();

        }
    }

}


