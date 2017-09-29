using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortune_Teller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I AM A GENIE... WHAT!... Is your first name?...");
            string firstName = (Console.ReadLine().ToLower().Trim());
           


            Console.WriteLine("Ahhh... WHAT! is your last name?");
            string lastName = (Console.ReadLine().ToLower().Trim());


            Console.WriteLine("How old are you, young one?");
            int userAge = int.Parse(Console.ReadLine());
            


            Console.WriteLine("What number month of the year were you spawned in?");
            int monthNumber = int.Parse(Console.ReadLine());



            Console.WriteLine("What is your favorite ROYGBIV color?...");
            Console.WriteLine("If you are confused as to what ROYGBIV means, type \"help\"");
            string favColor = (Console.ReadLine().ToLower().Trim());
            
            
            
            if (favColor == "help")
            {
                Console.WriteLine("Choose from: red, orange, yellow, green, blue, indigo, violet.");
                string userHelp = Console.ReadLine().ToLower();
            }
           else
            {
                Console.WriteLine("Proceed to the next question.");
            }

            Console.WriteLine("Now please tell me... How many siblings do you have?");
            int numSiblings = int.Parse(Console.ReadLine());

            Console.WriteLine("I have met many mortals, some you may know. Hugh Heffner, Dan Bilzerian to name a few.");
            Console.WriteLine("However " + firstName + " " + lastName + " I have never seen one as unlucky as you!");
            Console.WriteLine("If you wish to know your fortune... type \"KAZAAM\"");
            string showFortune = Console.ReadLine().ToUpper();

            if (showFortune == "KAZAAM")
            {
                Console.WriteLine("HERE IS YOUR FORTUNE!");
            }
            else
            {
                Console.WriteLine("Just type in KAZAAM bro...");
            }
        


            //part 2 

            //Age
            if (userAge % 2 == 0)
            {
                Console.WriteLine("hahaha my my....you are an unlucky one! You will be working until you croak!");
            }
            else
            {
                Console.WriteLine("Ahh, you are a lucky one! You will retire at the tender age of 35!");
            }

            //Number of Siblings

            if (numSiblings <= 0)
            {
                Console.WriteLine("Your vacation will be spent"); 
                Console.WriteLine("ice fishing with the Tsimishian Eskimo Tribe in British Columbia, Alaska.");
            }
            else if (numSiblings == 1)
            {
                Console.WriteLine("Your vacation will be spent on the islands of Bora Bora.");
            }
            else if (numSiblings == 2)
            {
                Console.WriteLine("Your vacation will be spent in beautiful Bangkok, Thailand.");
            }
            else if (numSiblings >= 3)
            {
                Console.WriteLine("You will spend your vacation in Aspen, Colorado with your homeboys/girls.");
            }




            // favorite color
            
            
            if (favColor == "red")
            {
                Console.WriteLine("Sorry buddy, You will drive a beat up red 1996 Toyota Corrolla.");
            }
            else if (favColor == "orange")
            {
                Console.WriteLine("Ayyee!! Looks like you'll be riding clean in an orange Porche Panamera.");
            }
            else if (favColor == "yellow")
            {
                Console.WriteLine("Hmmm... Your only means of transportation will be a yellow Nissan GTR.");
            }
            else if (favColor == "green")
            {
                Console.WriteLine("You will be atop a green camo humvee... You had a crazy dream one day and joined the army.");
            }
            else if (favColor == "blue")
            {
                Console.WriteLine("You will be riding on a blue skateboard"); 
                Console.WriteLine("as you became an apprentice under Tony Hawk");
            }
            else if (favColor == "indigo")
            {
                Console.WriteLine("You will be giving up all material items and devoting your life to the gods... (Press Enter)");
                Console.WriteLine("...Their power will grant you an indigo floating traveling cloud");
            }
            else if (favColor == "violet")
            {
                Console.WriteLine("You will be partying with Snoop Dog atop the Soul Plane, traveling from coast 2 coast.");
            }

            


        }
    }
}
