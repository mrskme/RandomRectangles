using System;
using System.Collections.Generic;
using System.Text;

namespace RandomRectangles
{
    public class Box
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int StartY => Y;
        public int EndY => Y + Height;
        public int Width { get; }
        public int Height { get; }
        private int _minimumSize = 3;

        private int XSpeed;
        private int YSpeed;

        public Box(Random random, int maxX, int maxY)
        {
            Width = random.Next(_minimumSize, maxX);
            Height = random.Next(_minimumSize, maxY);
            X = random.Next(1, maxX - Width);
            Y = random.Next(1, maxY - Height);
        }

        //public void Move(Random random, int maxX, int maxY)
        //{
        //    var oldX = X;
        //    var oldY = Y;
        //    XSpeed = random.Next(1, 4);
        //    YSpeed = random.Next(1, 4);
        //    if (X + Width + XSpeed >= maxX)  X = oldX;
        //    else X += XSpeed;
        //    if (EndY + YSpeed >= maxY) Y = oldY;
        //    else Y += YSpeed;
        //}
    }
}
