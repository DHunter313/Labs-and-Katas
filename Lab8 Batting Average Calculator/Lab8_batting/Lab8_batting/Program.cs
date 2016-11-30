using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_batting
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Batting Average Calculator\n\n\n");
            Console.Write("How many times are you at bat?  ");
            int atBats = int.Parse(Console.ReadLine());
            int[] BasesScored = new int[atBats];
            Console.WriteLine("\n\nEnter your results for at-bat.\n\n\n 0=out, 1=single, 2=double, 3=triple, 4=home run\n\n\n");
            for (int i = 0; i < atBats; i++)
            {
                Console.Write($"result for at-bat {(i) + 1}: ");
                int madeBases = int.Parse(Console.ReadLine());

                BasesScored[i] = madeBases;
                
            }

            Console.WriteLine(CalculateBattingAverage(BasesScored));
            Console.WriteLine(CalculateSluggingAverage(BasesScored));



        }

        private static void CalculateBattingAverage(int v)
        {
            throw new NotImplementedException();
        }

        public static double CalculateBattingAverage(int[] battingSheet)
        {
            int GoodHit = 0;

            for (int AtBatCount = 0; AtBatCount < battingSheet.Length; AtBatCount++)
            {
                if (battingSheet[AtBatCount] != 0)
                {
                    GoodHit++;
                }
            }

            return (double)GoodHit / battingSheet.Length;

        }

        public static double CalculateSluggingAverage(int[] battingSheet)
        {
            int baseRuns = 0;

            for (int AtBatCount = 0; AtBatCount < battingSheet.Length; AtBatCount++)
            {
                if (battingSheet[AtBatCount] != 0)
                {
                    baseRuns = baseRuns + battingSheet[AtBatCount];
                        }
                
                
            }

            return (double)baseRuns / battingSheet.Length;

        }
    }
}
