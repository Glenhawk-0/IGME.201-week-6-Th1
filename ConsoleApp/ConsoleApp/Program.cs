﻿namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //varibles
            string playerName = "adventurer";
            string userChoice = "NONE";



            //--

            //intro to jungle
            Console.Write("Welcome to the jungle \nWe got fun and games \nWe got everything you want \nHoney, we know the names \n ");
            Console.WriteLine("Wait... I don't actually know your name.");
            Console.WriteLine("What is your name?");
            Console.WriteLine("[Please enter your name, then press 'ENTER' on the keyboard]");

            //added user input
            playerName = Console.ReadLine();
            Console.WriteLine("\nWelcome to the jungle " + playerName + "!");

            // start adventurin the jungle
            Console.WriteLine("" +
            "We approach a clearing in the jungle\n" +
            "There seems to be a trail to the left...\n" +
            "And a cave entrance to the right.\n"
                );

            //present choice
            Console.WriteLine("Which path do you chose?");
            Console.WriteLine("Type 'left' to choose the path and go left or type 'right' to choose the cave and go right.");

            //user input choice
            userChoice = Console.ReadLine();
            Console.WriteLine("\nYou chose: " + userChoice + "\n");

            if (userChoice == "left")
            {
                //Go to the left
                Console.WriteLine("You take the path to the left. It leads you out of the jungle. You are safe to adventure another day!");

            }
            else if (userChoice == "right")
            {
                //Go to the right
                Console.WriteLine("You take the path to the right. It leads you into a cave. There is a cave in and you are trapped!");
            }
            else
            {
                //Oh no! the user typed in something else.
                userChoice = "NONE";

                while (userChoice != "left" && userChoice != "right" && userChoice != "up")
                {
                    Console.WriteLine("Please enter either 'left', 'right', or our now super secret answer of 'up'.");
                    userChoice = Console.ReadLine();
                    Console.WriteLine("\nYou chose: " + userChoice + "\n");
                }

                if (userChoice == "left")
                {
                    //Go to the left
                    Console.WriteLine("You take the path to the left. It leads you out of the jungle. You are safe to adventure another day!");
                }
                else if (userChoice == "right")
                {
                    //Go to the right
                    Console.WriteLine("You take the path to the right. It leads you into a cave. There is a cave in and you are trapped!");
                }
                else if (userChoice == "up")
                {
                    //Easter Egg
                    Console.WriteLine("'up' seriously? 'up'!? How can we go up? UP YOURS! |_(O_O)_/ **Flips keyboard** CLOSE THE PROGRAM!");
                }
                else
                {
                    Console.WriteLine("I honestly don't know how you got here. Congrats.");
                }
            }
        }//end static void
    }// end internal class
}//end
