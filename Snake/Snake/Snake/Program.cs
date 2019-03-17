using System;

namespace Snake
{
    class Program
    {
        static void Main()
        {
            Console.CursorVisible = false;
            Game game = new Game();
            game.Start();
        }
    }
}
