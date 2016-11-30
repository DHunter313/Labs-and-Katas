using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizReverseAString
{
    class Program
    {

        public static void Main(string[] args)
        {
            
	// 30 minutes to come up with a working app to reverse strings, without the use of 
		//the internet.


            Console.WriteLine("Welcome to Rever-The-Word App\n\n");
            Console.WriteLine("enter a word or sentence to reverse:");
            string userInput = Console.ReadLine();

            int wordCount= userInput.Length;
            Console.Write("The reversed version is: ");

            for (int i = wordCount; i <=userInput.Length+1; i--)
            {
                try { Console.Write(userInput.ToCharArray()[i - 1]); }
                catch (IndexOutOfRangeException) { }

            }
            
            // Console.WriteLine(   userInput[3]);

            //Console.WriteLine(userInput.ToArray<>());


            //for (int i = userInput.Length; i >= userInput.Length; i--)
            //{
            //Console.WriteLine(userInput.Substring(i,1));

            //}

            Console.ReadKey();

        }
    }
}
