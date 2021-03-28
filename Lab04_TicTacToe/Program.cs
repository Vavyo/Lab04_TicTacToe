using Lab04_TicTacToe.Classes;
using System;

namespace Lab04_TicTacToe
{
    class Program
    {
        // private bool active = true;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // while (active){
            StartGame();
            // } end while
        }

        static void StartGame()
        {
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 
            Console.WriteLine("Player 1:");
            Player p1 = new Player();
            p1.Name = Console.ReadLine();
            p1.Marker = "X";

            Console.WriteLine("Player 2:");
            Player p2 = new Player();
            p2.Name = Console.ReadLine();
            p2.Marker = "O";

            Game game = new Game(p1, p2);
            Player winner = game.Play();

            if (winner is null)
                Console.WriteLine($"Sorry. No winner this time.");
            else
                Console.WriteLine($"Congrats, {winner.Name}, you won!");
            // ask to play again
            // if yes
            // active = true
            // if no 
            // active false
        }
    }
}
