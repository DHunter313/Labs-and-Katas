using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GC_ClassroomLibrary;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Classroom expNet = new Classroom();

            for (int i = 0; i < expNet.students.Length; i++)
            {
                expNet.students[i] = new Student();
            }
            Console.WriteLine("Welcome to our .NET Class.\n\n\n\n");

            string cont;

            do
            {
                Console.WriteLine("Which student would you like to learn more about?\n");


                try
                {
                    Console.Write("(please enter a number 1-20): ");
                    int stuName = Convert.ToInt32(Console.ReadLine());

                    expNet.students[1].Name = "Kim";
                    expNet.students[1].HomeTown = "Detroit";
                    expNet.students[1].favoriteFood = "Burritos";

                    expNet.students[2].Name = "Mo";
                    expNet.students[2].HomeTown = "Beijing";
                    expNet.students[2].favoriteFood = "Pho";

                    expNet.students[3].Name = "Gayatri";
                    expNet.students[3].HomeTown = "Hyderabadh, India";
                    expNet.students[3].favoriteFood = "Dosa";

                    expNet.students[4].Name = "Mike";
                    expNet.students[4].HomeTown = "Grosse Pointe";
                    expNet.students[4].favoriteFood = "Pizza";

                    expNet.students[5].Name = "Athikumar";
                    expNet.students[5].HomeTown = "Chenni, India";
                    expNet.students[5].favoriteFood = "Fruits";

                    expNet.students[6].Name = "Renee";
                    expNet.students[6].HomeTown = "Detroit";
                    expNet.students[6].favoriteFood = "Burritos";

                    expNet.students[7].Name = "Phil";
                    expNet.students[7].HomeTown = "Detroit";
                    expNet.students[7].favoriteFood = "Burritos";

                    expNet.students[8].Name = "Michelle";
                    expNet.students[8].HomeTown = "Detroit";
                    expNet.students[8].favoriteFood = "Burritos";

                    expNet.students[9].Name = "Christian";
                    expNet.students[9].HomeTown = "Detroit";
                    expNet.students[9].favoriteFood = "Pizza";

                    expNet.students[10].Name = "Rummy";
                    expNet.students[10].HomeTown = "Ireland";
                    expNet.students[10].favoriteFood = "Goat";

                    expNet.students[11].Name = "Raizo";
                    expNet.students[11].HomeTown = "Farmington Hills";
                    expNet.students[11].favoriteFood = "Pastrolli";

                    expNet.students[12].Name = "Drake";
                    expNet.students[12].HomeTown = "The 6, Canada";
                    expNet.students[12].favoriteFood = "Truffles";

                    expNet.students[13].Name = "Geedy";
                    expNet.students[13].HomeTown = "South Lyon, MI";
                    expNet.students[13].favoriteFood = "Pasta";

                    expNet.students[14].Name = "El Yossi";
                    expNet.students[14].HomeTown = "Chango, Nigeria";
                    expNet.students[14].favoriteFood = "Beef";

                    expNet.students[15].Name = "Kimiko";
                    expNet.students[15].HomeTown = "Tokyo, Japan";
                    expNet.students[15].favoriteFood = "Yakisoba";

                    expNet.students[16].Name = "Jimmy";
                    expNet.students[16].HomeTown = "New Orleans, LA";
                    expNet.students[16].favoriteFood = "Gator Meat";

                    expNet.students[17].Name = "Pablo";
                    expNet.students[17].HomeTown = "Santiago, Brazil";
                    expNet.students[17].favoriteFood = "Ca-Ca";

                    expNet.students[18].Name = "Noriega";
                    expNet.students[18].HomeTown = "Miami, Fl";
                    expNet.students[18].favoriteFood = "Lobster";

                    expNet.students[19].Name = "Heins";
                    expNet.students[19].HomeTown = "Weinsburg, Germany";
                    expNet.students[19].favoriteFood = "Chocolate";

                    expNet.students[20].Name = "Jim";
                    expNet.students[20].HomeTown = "Bedrock, California";
                    expNet.students[20].favoriteFood = "Shrimp";

                    Console.WriteLine($"\nStudent {stuName} is {expNet.students[stuName].Name}.");
                    string learnMore;

                    do
                    {
                        Console.WriteLine($"\nWhat would you like to learn about {expNet.students[stuName].Name}?\n\n");

                        Console.WriteLine($"enter -hometown- or -favorite food-");

                        string moreInfo = Console.ReadLine();

                        if (moreInfo == "hometown" || moreInfo == "HOMETOWN")
                        {
                            Console.WriteLine($"\n{expNet.students[stuName].Name} is from {expNet.students[stuName].HomeTown}.\n");
                        }

                        else if (moreInfo == "favorite food" || moreInfo == "FAVORITE FOOD")
                        {
                            Console.WriteLine($"\n{expNet.students[stuName].Name}'s favorite food is {expNet.students[stuName].favoriteFood}.\n");
                        }

                        else
                        {
                            Console.WriteLine("Data does not exist. Please type in a 'hometown' or 'favorite food'\n");
                        }

                        Console.WriteLine($"\nWould you like to learn more about {expNet.students[stuName].Name}?  (y/n)");
                        learnMore = Console.ReadLine();
                    } while (learnMore == "y" || learnMore == "Y");



                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("That student does not exist. Please try again.");
                }
                catch (FormatException)
                {
                    Console.WriteLine(" Don't use Letters. Please only enter number 1-20");
                }
                catch (Exception)
                {
                    Console.WriteLine("An exception is caught");
                    Console.WriteLine("please enter a valid number");
                }

                Console.WriteLine("\nDo you want to pick another student to learn more about?   y or n ");
                cont = Console.ReadLine();
            } while (cont == "y" || cont == "Y");

            Console.WriteLine("Thank you and GOOD-BYE");

            Console.ReadKey();

        }
    }

}
