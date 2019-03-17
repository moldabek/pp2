using System;
using System.Collections.Generic;

namespace Snake
{
    public class  GObject
    {
        public List<Point> body;
        public char sign;
        ConsoleColor color;

        public GObject() { }
        public GObject(int x, int y, char sign, ConsoleColor color)
        {
            body = new List<Point>();
            body.Add(new Point(x, y));
            this.sign = sign;
            this.color = color; 
        }
        public bool IsCollision(GObject go)
        {
           for(int i=0;i < go.body.Count; i++)
            {
                if (go.GetType() == typeof(Snake) && i == 0) 
                    continue;
                if (this.body[0].x == go.body[i].x && this.body[0].y == go.body[i].y)
                {
                    return true;
                }
            }
            return false;
        }
        
        public void Draw()
        {
            Console.ForegroundColor = color;
            foreach(Point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
            }
        }

    }
}
