using System.Reflection.Metadata;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string playerName = Console.ReadLine();
            int userScore = 0;
            int computerScore = 0;
            int ties = 0;
            int round = 1;
            
            

            while (true)
            {
                Console.WriteLine($"\n---Round {round}---");

                string userItem = GetHumanItem();
                if (userItem == "quit")
                {
                    Console.WriteLine("\nFinal Score: ");
                    Console.WriteLine($"{playerName}:  {userScore} | Computer: {computerScore} | Ties: {ties}");
                    Console.WriteLine("Thanks for playing! ");
                    break;
                }
                string computerItem = GetComputerItem();
                Console.WriteLine($"\n{playerName} chose: {userItem} vs Computer chose: {computerItem}");

                round++;


                if (userItem == computerItem)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("It's a tie!");
                    Console.ResetColor();
                    ties++;
                }
                else if ((userItem == "rock" && computerItem == "scissors") ||
                        (userItem == "paper" && computerItem == "rock") ||
                        (userItem == "scissors" && computerItem == "paper"))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{playerName} wins! ");
                    Console.ResetColor();
                    userScore++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Computer wins! go get a job you bum");
                    Console.ResetColor();
                    computerScore++;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{playerName}:  {userScore} ");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"Computer: {computerScore} ");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"Ties: {ties}\n");
                Console.ResetColor();
            }
            
               
        }

        static string GetComputerItem()
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(3);
            switch (randomNumber)
            {
                case 0:
                    return "rock";
                case 1:
                    return "scissors";
                case 2:
                    return "paper";
                default:
                    return "Tyranosaurus Rex";
            }
        }

        static string GetHumanItem()
        {
            
            Console.Write("Enter your item (rock, paper, scissors): ");
            string userItem = Console.ReadLine();

            while (userItem != "rock" && userItem != "paper" && userItem != "scissors" && userItem !="quit")
            {
                Console.Write("Invalid item, please enter rock, paper, or scissors: "); 
                userItem = Console.ReadLine();

                if(userItem != "rock" && userItem != "paper" && userItem != "scissors")
                {
                    Console.WriteLine("Seriously? You can't follow simple instructions? ");
                }
            }
            return userItem;        
        }
       
        


       

    }
}
