// se referer au dossier boucle imbriquer 2

using System;
using System.Collections.Generic;

namespace nbrgame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the number game");
            Console.WriteLine("You got only 3 try to found the number betweeen 1-5");
            Console.WriteLine("do you think you can make it?");

            string userAnswer = Console.ReadLine();

            if (userAnswer == "yes" || userAnswer == "oui")
            {
                Console.WriteLine("You said yes. the game is about to start");
            }
            else if (userAnswer == "no" || userAnswer == "non")
            {
                Console.WriteLine("You answer is no");
                Console.WriteLine("Maybe next time");
            }
            else
            {
                while (userAnswer != "yes" || userAnswer != "oui" || userAnswer != "no" || userAnswer != "non")
                {
                    Console.WriteLine("i dont understand what you trying to tell me");
                    Console.WriteLine("try again. answer possible are: ");
                    Console.WriteLine("yes,oui,no,non");

                    userAnswer = Console.ReadLine();

                    if (userAnswer == "yes" || userAnswer == "oui")
                    {
                        Console.WriteLine("You said yes. the game is about to start");
                        break;
                    }
                    else if (userAnswer == "no" || userAnswer == "non")
                    {
                        Console.WriteLine("You answer is no");
                        Console.WriteLine("Maybe next time");
                        break;
                    }

                    else
                    {
                        Console.WriteLine("i dont understand what you trying to tell me");
                        Console.WriteLine("try again. answer possible are: ");
                        Console.WriteLine("yes,oui,no,non");
                        
                    }//tout fonctionne jusqu'ici
                }
            }




            Console.WriteLine("le test fonctionne");

            Console.Read();
        }
    }
}
/* do
   {
       Console.WriteLine("i dont understand what you trying to tell me");
       Console.WriteLine("try again. answer possible are: ");
       Console.WriteLine("yes,oui,no,non");

       Console.ReadLine();
   }
   while (userAnswer != "yes" || userAnswer != "oui" || userAnswer != "no" || userAnswer != "non");

       if (userAnswer == "yes" || userAnswer == "oui")
       {
           Console.WriteLine("You said yes. the game is about to start");
       }
       else
       {
           Console.WriteLine("You answer is no");
           Console.WriteLine("Maybe next time");
       }


   if (userAnswer == "yes" || userAnswer == "oui")
   {
       Console.WriteLine("You said yes. the game is about to start");
   }
   else
   {
       Console.WriteLine("You answer is no");
       Console.WriteLine("Maybe next time");






                switch(userAnswer)
                {
                    case "yes":
                        Console.WriteLine("You said yes. the game is about to start");
                        break;
                    case "oui":
                        Console.WriteLine("You said yes. the game is about to start");
                        break;
                    case "no":
                        Console.WriteLine("You answer is no");
                        Console.WriteLine("Maybe next time");
                        break;
                    case "non":
                        Console.WriteLine("You answer is no");
                        Console.WriteLine("Maybe next time");
                        break;
                    default:
                        Console.WriteLine("i dont understand what you trying to tell me");
                        Console.WriteLine("try again. answer possible are: ");
                        Console.WriteLine("yes,oui,no,non");
                        break;
                }





      string userWrong = Console.ReadLine();

                Console.ReadLine();
                if (userWrong == "yes" || userWrong == "oui")
                {
                    Console.WriteLine("You said yes. the game is about to start");
                }
                else if (userWrong == "no" || userWrong == "non")
                {
                    Console.WriteLine("You answer is no");
                    Console.WriteLine("Maybe next time");
                }
                else
                {
                    Console.ReadLine();

                }
   }

 
 
 
 
 
 do
            {
                Console.WriteLine("i dont understand what you trying to tell me");
                Console.WriteLine("try again. answer possible are: ");
                Console.WriteLine("yes,oui,no,non");

                userAnswer = Console.ReadLine();

                if (userAnswer == "yes" || userAnswer == "oui")
                {
                    Console.WriteLine("You said yes. the game is about to start");
                }
                if (userAnswer == "no" || userAnswer == "non")
                {
                    Console.WriteLine("You answer is no");
                    Console.WriteLine("Maybe next time");
                }
                

            } while (userAnswer == "yes" || userAnswer != "oui" || userAnswer != "no" || userAnswer != "non");
 */