namespace ConsoleApp
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

        }//end static void
    }//end internal class
}//end
