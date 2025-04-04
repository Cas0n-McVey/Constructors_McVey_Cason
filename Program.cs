using System;

namespace Constructors_McVey_Cason
{
    class Program
    {
        static void Main(string[] args)
        {
            // Have my title and genre because it have both title and genre in Game.cs
            Game myGame = new Game("Terraria", "T for Teen");

            // To paint my string and myGame code
            Console.WriteLine($"My favorite game is {myGame.title} and it is rated {myGame.genre}!");

            // To show you what happens if you don't have a title and genre and call it a different variable
            Game myOtherGame = new Game();

            // To paint what happen if we don't have a title and genre
            Console.WriteLine($"My other favorite game is {myOtherGame.title} and it is rated {myOtherGame.genre}!");
        }
    }
}