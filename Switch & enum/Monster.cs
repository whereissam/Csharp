using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class Monster
    {
        private int X;
        private int Y;

        public void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.UP:
                    Y += 1;
                    break;
                case Direction.DOWN:
                    Y -= 1;
                    break;
                case Direction.LEFT:
                    X -= 1;
                    break;
                case Direction.RIGHT:
                    X += 1;
                    break;
                default:
                    break;
            }
            /*
            if(direction == 1)
            {
                Y += 1;
            } else if(direction == 2)
            {
                Y -= 1;
            } else if (direction == 3)
            {
                X -= 1;
            } else if (direction == 4)
            {
                X += 1;
            }
            */
        }
        public string ReportPosition()
        {
            return "怪物在(" + X + "," + Y + ")";
        }

    }
}
