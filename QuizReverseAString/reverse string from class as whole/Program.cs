using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_string_from_class_as_whole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write the word to be reversed");
            string word = Console.ReadLine();

            string reverse2 = word.Reverse().ToString();
            //char[] reverse = word.ToCharArray();
            //char[] outputCharArray = new char[reverse.Length];
            //string reversdWord = "";
            //for (int i = reverse.Length-1; i >= 0; i--)
            //{

            //    reversdWord += reverse[i];

            //}
            //Console.WriteLine( reversdWord );
            Console.WriteLine(reverse2); 

        }
    }
}
