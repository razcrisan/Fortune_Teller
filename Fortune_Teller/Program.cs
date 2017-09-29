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
            // first name
            Console.WriteLine("I AM A GENIE... What s your first name?...");
            string firstName = (Console.ReadLine().Trim());
           
            // last name
            Console.WriteLine("Ahhh... What is your last name?");
            string lastName = (Console.ReadLine().Trim());

            //age
            Console.WriteLine("How old are you, young one?");
            int userAge = int.Parse(Console.ReadLine());
            

            //month
            Console.WriteLine("Sweet, now type in your birth month in the form of a number.");
            int monthNumber = int.Parse(Console.ReadLine());


            //color
            Console.WriteLine("What is your favorite ROYGBIV color?...");
            Console.WriteLine("If you are confused as to what ROYGBIV means, type in \"help\"");
            string favColor = (Console.ReadLine().ToLower().Trim());
            
            if (favColor == "help")
            {
                Console.WriteLine("Choose from: red, orange, yellow, green, blue, indigo, violet.");
                favColor = Console.ReadLine().ToLower();
            }
           else
            {
                Console.WriteLine("Proceed.");
            }



            //siblings
            Console.WriteLine("Now please tell me... How many siblings do you have?");
            int numSiblings = int.Parse(Console.ReadLine());



         

            //part 2 




            //Age (retirement)
            if (userAge % 2 == 0)

            {
               
                Console.WriteLine( firstName + " " + lastName +  ", you will retire in 25 years");
            }
            else
            {
                Console.WriteLine("You are a lucky one, " + firstName + " " + lastName + " " + ",you will retire next year");
            }






            //monthNumber (Birth Month) (money in the bank)

            if (monthNumber >= 1 || monthNumber <= 4)
            {
                Console.WriteLine("with $50,000 in the bank");
            }
            else if (monthNumber >= 5 || monthNumber <= 8)
            {
                Console.WriteLine("with $200,000,000 in the bank");
            }
            else if (monthNumber >= 9 || monthNumber <= 12)
            {
                Console.WriteLine("with $5,000 in the bank");
            }
            else if (monthNumber < 1 || monthNumber > 12)
            {
                Console.WriteLine("with a measly $0.00 in the bank");
            }
                   




            //Number of Siblings (vacation home)

            if (numSiblings <= 0)
            {
                Console.WriteLine("with a vacation home along the"); 
                Console.WriteLine("Tsimishian Eskimo Tribe in British Columbia, Alaska");
            }
            else if (numSiblings == 1)
            {
                Console.WriteLine("with a vacation home on the islands of Bora Bora");
            }
            else if (numSiblings == 2)
            {
                Console.WriteLine("with a vacation home in beautiful Bangkok, Thailand");
            }
            else if (numSiblings >= 3)
            {
                Console.WriteLine("with a vacation home in Aspen, Colorado");
            }




            // favorite color/ transportation
            
            
            if (favColor == "red")
            {
                Console.WriteLine("and you will be driving a red 1991 Toyota Corrolla.");
            }
            else if (favColor == "orange")
            {
                Console.WriteLine("and it looks like you'll be traveling in an orange giant, fuzzy peach");
            }
            else if (favColor == "yellow")
            {
                Console.WriteLine("and your means of transportation will be a yellow Nissan GTR.");
            }
            else if (favColor == "green")
            {
                Console.WriteLine("and your ride will be a fully loaded green unicycle");
            }
            else if (favColor == "blue")
            {
                Console.WriteLine("a blue hoverboard"); 
                
            }
            else if (favColor == "indigo")
            {
                Console.WriteLine("and since you gave up all material items and devoted your life to the gods,");
                Console.WriteLine("their power granted you an indigo nimbus cloud for transportation");
            }
            else if (favColor == "violet")
            {
                Console.WriteLine("and you will be riding your trusty dragon steed... Yes a dragon.");
            }



           


        }
    }
}
