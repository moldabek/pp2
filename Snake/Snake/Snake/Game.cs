using System;
using System.Collections.Generic;
using System.Threading;
namespace Snake
{
    public class Game
    {
        List<GObject> g_objects;
        public bool isAlive;
        public Snake snake;
        public Food food;
        public Wall wall;
        int levels = 200;
        int score = 0;
 
        public Game()
        {
            g_objects = new List<GObject>();
           
            snake = new Snake(1, 1, '*', ConsoleColor.White);
            wall = new Wall('#', ConsoleColor.Green);
            wall.LoadLevel();
            food = new Food( 0,0,'o', ConsoleColor.Red);
            
                food.Generate(snake,wall);

            
            g_objects.Add(snake);
            g_objects.Add(food);
            g_objects.Add(wall);

             isAlive = true;

            
        }
        public void Start()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            Thread thread = new Thread(SnakeMove);
            thread.Start();

            while(isAlive && keyInfo.Key != ConsoleKey.Escape)
            {
                keyInfo = Console.ReadKey();
                snake.Change(keyInfo);
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(20, 10);
            Console.WriteLine("GAME OVER !!! " + "Your score : "+score);
            Console.ReadLine();

        }
        public void SnakeMove()
        {
            while (isAlive)
            {
                snake.Move();
                if (snake.IsCollision(food))
                {
                    score += 10;
                    snake.body.Add(new Point(0, 0));
                        
                            food.Generate(snake,wall);


                    if (snake.body.Count % 3 == 0)
                    {
                        wall.NextLevel();
                        levels -= 50;
                    }
                }
                if (snake.IsCollision(wall))
                {
                    isAlive = false;
                    
                }
                if (snake.IsCollision(snake))
                {
                    isAlive = false;
                }

                Draw();
                Thread.Sleep(levels);
            }
        }
            public void Draw()
            {
                Console.Clear();

                foreach(GObject g in g_objects)
                {
                    g.Draw();
                }
            }
    }
}
