using System;
namespace Snake
{
    public class Food:GObject
    {
        public Food(int x, int y, char sign, ConsoleColor color) : base(x, y, sign, color)
        {

        }
        public void Generate(Snake snake,Wall wall)
        {
            bool ok = true;
            while (ok)
            {
                Random ra = new Random();
                body[0].x = ra.Next(1, Console.WindowWidth);
                body[0].y = ra.Next(1, Console.WindowHeight);
                ok = false;
                foreach(Point p in snake.body)
                {
                    if (p.x == body[0].x && p.y == body[0].y)
                        ok = true;
                }
                foreach(Point p in wall.body)
                {
                    if (p.x == body[0].x && p.y == body[0].y)
                        ok = true;
                }
            }

            
        }
    }
}
