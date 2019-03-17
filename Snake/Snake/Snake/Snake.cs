using System;

namespace Snake
{
    public class Snake : GObject
    {
        enum Direction
        {
            NONE,
            DOWN,
            LEFT,
            RIGHT,
            UP
        }
        Direction direct = Direction.NONE;

        public  Snake(int x, int y, char sign, ConsoleColor color):base(x, y, sign, color)
        {

        }
        public void Move()
        {
            if(direct == Direction.NONE)
            {
                return;
            }
            for (int i = body.Count - 1; i > 0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }


            if (direct == Direction.UP)
            {
                if (body[0].y == 0)
                {
                    body[0].y = 30;
                }
                body[0].y--;
            }   
           if(direct == Direction.DOWN)
            {
                if (body[0].y == 30)
                {
                    body[0].y = 0;
                }
                body[0].y++;
            }
           if(direct == Direction.RIGHT)
            {
                if (body[0].x == 119)
                {
                    body[0].x = 0;
                }
                body[0].x++;
            }
           if(direct == Direction.LEFT)
            {
                if (body[0].x == 0)
                {
                    body[0].x = 119;
                }
                body[0].x--;
            }
        }

        public void Change(ConsoleKeyInfo  keyInfo)
        {
            if(keyInfo.Key == ConsoleKey.UpArrow)
            {
                direct = Direction.UP;
            }
            if (keyInfo.Key == ConsoleKey.DownArrow)
            {
                direct = Direction.DOWN;
            }
            if (keyInfo.Key == ConsoleKey.LeftArrow)
            {
                direct = Direction.LEFT;
            }
            if (keyInfo.Key == ConsoleKey.RightArrow)
            {
                direct = Direction.RIGHT;
            }
        }
    }
}
