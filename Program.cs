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
            Console.WriteLine("im gonna generate a 10 digit number for you");
            Console.WriteLine("do you wanna play the game");

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
            int nbr1 = 5;
            int nbr2 = 1;
            int nbr3 = 4;
            Random nbrRandom = new Random();

            //int nbr1 = nbrRandom.Next(0, 9);
            //int nbr2 = nbrRandom.Next(0, 9);
            //int nbr3 = nbrRandom.Next(0, 9);
            int nbr4 = nbrRandom.Next(0, 9);
            int nbr5 = nbrRandom.Next(0, 9);
            int nbr6 = nbrRandom.Next(0, 9);
            int nbr7 = nbrRandom.Next(0, 9);
            int nbr8 = nbrRandom.Next(0, 9);
            int nbr9 = nbrRandom.Next(0, 9);
            int nbr10 = nbrRandom.Next(0, 9);


            Console.WriteLine("now Call that number");
            Console.WriteLine("");
            Console.Write(nbr1);
            Console.Write(nbr2);
            Console.Write(nbr3);

            Console.WriteLine("-" + nbr4 + nbr5 + nbr6 + "-" + nbr7 + nbr8 + nbr9 + nbr10);
            Console.WriteLine("call it");
            Console.WriteLine("test windows reussis");
            Console.WriteLine("test mac reussis");

            //tout fonctionne jusqu'ici





            Console.WriteLine("le test fonctionne");

            Console.Read();
        }
    }
}
