using System;
using System.Collections.Generic;
using System.Text;

namespace RandomRectangles
{
    class VirtualScreenCell
    {
        public bool Up { get; private set; }
        public bool Down { get; private set; }
        public bool Left { get; private set; }
        public bool Right { get; private set; }
        public char GetCharacter()
        {
            if (Up && Down && Left && Right) return '┼';
            if (Up && Down && Left) return '┤';
            if (Up && Down && Right) return '├';
            if (Up && Left && Right) return '┴';
            if (Down && Left && Right) return '┬';
            if (Down && Left) return '┐';
            if (Down && Right) return '┌';
            if (Up && Left) return '┘';
            if (Up && Right) return '└';
            if (Up && Down) return '│';
            if (Left && Right) return '─';
            if (Up) return '╹';
            if (Down) return '╻';
            if (Left) return '╸';
            if (Right) return '╺';
            return ' ';
        } 

        public void AddHorizontal()
        {// done
            Left = true;
            Right = true;

            //Up = false;
            //Down = false;
        }

        public void AddVertical()
        {//done
            Up = true;
            Down = true;

            //Left = false;
            //Right = false;
        }

        public void AddLowerLeftCorner()
        {
            Up = true;
            Right = true;

            //Down = false;
            //Left = false;
        }

        public void AddLowerRightCorner()
        {
            Up = true;
            Left = true;

            //Down = false;
            //Right = false;
        }

        public void AddUpperLeftCorner()
        {
            Down = true;
            Right = true;

            //Up = false;
            //Left = false;
        }

        public void AddUpperRightCorner()
        {
            Down = true;
            Left = true;

            //Up = false;
            //Right = false;
        }
    }
}
