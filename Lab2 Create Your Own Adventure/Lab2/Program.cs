using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("What is your name? (enter your name)");
                string name = Console.ReadLine();
                //---------name----------
                Console.WriteLine("Hello " + name + "! Would you like to play a game? (enter yes or no)");
                string play = Console.ReadLine();
            //---------------play the game--------
            if (play == "yes")
            {
                Console.WriteLine();
                Console.WriteLine("\n Muhahahahaaaa. Most excellent!");
                //---------------------Facing the beast-----------------
                Console.WriteLine("You are walking across a field and you encounter a black-scaled Dragon!\n You can feel the power emanating from it.\n You know that this is the legendary Chaos Dragon.\n Known to bring about swift destruction to all in its wake.\n \n \n What would you do? (face the beast or run away)");
                string face = Console.ReadLine();

                if (face == "face the beast")
                { 
                    Console.WriteLine("\n You approach the dragon. You can feel its overwhelming power as you near it.\n It stares at you with its ___ heads. (enter '1 or 2 or 3')\n ");
                    
                    string heads = Console.ReadLine();
                    
                  int noh = Convert.ToInt32 (heads, 4);
      
                    switch (noh)
                    { 
                        case 1:
                            {
                        Console.WriteLine(" No man has ever made an enemy of a Dragon and lived to tell the tale!!!\n \n ");
                        Console.WriteLine(" Choose the weapon that will serve as your salvation. \n (sword or rifle or bare-hands)\n \n ");
                             }
                         break;
                
                         case 2:       
                            {
                    Console.WriteLine(" No man has ever faced the twin headed hydra and lived to tell the tale!!!\n \n ");
                    Console.WriteLine(" Choose the weapon that will serve as your salvation. \n (sword or rifle or bare-hands)\n \n ");
                             }
                            break;
                        default:
                             {
                    Console.WriteLine(" No man has ever faced the deadly tri-headed dragon and lived to tell the tale!!!\n \n ");
                    Console.WriteLine(" Choose the weapon that will serve as your salvation. \n (sword or rifle or bare-hands)\n \n ");

                             }
                            break;
                     }
                    string weapon = Console.ReadLine();
                    Console.WriteLine("Armed with your " + weapon + ". You approach the Dragon.");
                    Console.WriteLine("You feel naked as the gaze of the Dragon pierces the darkest depths of your soul.");
                    Console.WriteLine("It stares at you with its ___ all-seeing eyes. (enter the color");
                    string eyes = Console.ReadLine();

                    Console.WriteLine("It is said that Dragons with " + eyes + " have been know to show mercy to those with a pure heart.\n \n");
                    Console.WriteLine("the Dragon speaks 'Do you have a pure heart?'");
                    Console.WriteLine("yes or no");
                    string heart = Console.ReadLine();
                    if (heart == "yes")
                    {
                        Console.WriteLine("\n YOU DARE LIE TO A DRAGON?!!!!\n \n I can see the hearts of men and yours is not pure.");
                        Console.WriteLine("\n You have been devoured. ");
                    } else {
                        Console.WriteLine("\n you are honest and I will let you live.");
                    }
                }
                else  { Console.WriteLine("\n \n You have faild to uphold your courage and you are a disgrace.\n BE GONE FROM MY SIGHT\n \n"); }

            } else  { Console.WriteLine(" \n You would've lost anyway. "); }
            

        }
    }
}
