using System;
using System.Collections.Generic;
using System.Text;

namespace RPS
{
    internal class RPSApp
    {
        public RPSApp()
        {
            Console.WriteLine("What is your name?");
            string player = Console.ReadLine();

            UserPlayer player1 = new UserPlayer(player);

            Console.WriteLine("Who would you like to play with 1) Randa 2) Rocky");
            string answer = Console.ReadLine();
            int pi = 0;
            int ci = 0;
            if (answer == "1")
            {
                while (true)
                {
                    Randa mainRA = new Randa("Randa");
                    string choice = player1.GenerateRPS().ToString();
                    string comp = mainRA.GenerateRPS().ToString();
                    Console.WriteLine($"You picked: {choice}");
                    Console.WriteLine($"Randa picked: {comp}");
                    string winner = Play(choice, comp);
                    if (winner == choice)
                    {
                        Console.WriteLine($"{player1.Name} is the winner!!!!!");
                        pi++;
                    }
                    else if (winner == comp)
                    {
                        Console.WriteLine($"{mainRA.Name} is the winner!!!!!");
                        ci++;
                    }
                    else
                    {
                        Console.WriteLine("It is a draw!");
                    }
                    Console.WriteLine("Do you want to play again? (Enter y/n)");
                    string again = Console.ReadLine();
                    if (again == "y")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else if (answer == "2")
            {
                while (true)
                {
                    Rocky mainRY = new Rocky("Rocky");
                    string choice = player1.GenerateRPS().ToString();
                    string comp = mainRY.GenerateRPS().ToString();
                    Console.WriteLine($"You picked: {choice}");
                    Console.WriteLine($"Rocky picked: {comp}");
                    string winner = Play(choice, comp);
                    if (winner == choice)
                    {
                        Console.WriteLine($"{player1.Name} is the winner!!!!!");
                        pi++;
                    }
                    else if (winner == comp)
                    {
                        Console.WriteLine($"{mainRY.Name} is the winner!!!!!");
                        ci++;
                    }
                    else
                    {
                        Console.WriteLine("It is a draw!");
                    }
                    Console.WriteLine("Do you want to play again? (Enter y/n)");
                    string again = Console.ReadLine();
                    if (again == "y")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            if (pi > ci)
            {
                Console.WriteLine($"{player1.Name} won this round!!!!!");
            }
            else if (pi < ci)
            {
                Console.WriteLine("The computer won this round!!!!!");
            }
            else
            {
                Console.WriteLine("No winners this round!");
            }
        }

        public string Play(string user, string compupter)
        {
            if (user == "Rock" && compupter == "Scissors")
            {
                return user;
            }
            else if (user == "Rock" && compupter == "Paper")
            {
                return compupter;
            }
            else if (user == "Rock" && compupter == "Rock")
            {
                return "Draw";
            }
            if (user == "Scissors" && compupter == "Rock")
            {
                return compupter;
            }
            else if (user == "Scissors" && compupter == "Paper")
            {
                return user;
            }
            else if (user == "Scissors" && compupter == "Scissors")
            {
                return "Draw";
            }
            if (user == "Paper" && compupter == "Rock")
            {
                return user;
            }
            else if (user == "Paper" && compupter == "Scissors")
            {
                return compupter;
            }
            else
            {
                return "Draw";
            }
        }
    }
}