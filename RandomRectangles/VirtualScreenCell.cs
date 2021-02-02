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
            if (Down && Left && Right) return '┬';
            if (Up && Left && Right) return '┴';
            if (Up && Left) return '┘';
            if (Up && Right) return '└';
            if (Down && Left) return '┐';
            if (Down && Right) return '┌';
            if (Left && Right) return '─';
            if (Up && Down) return '│';
            if (Up) return '╹';
            if (Down) return '╻';
            if (Left) return '╺';
            if (Right) return '╸';
            return ' ';
        }

        public void AddHorizontal()
        {
            Left = true;
            Right = true;
        }

        public void AddVertical()
        {
            Up = true;
            Down = true;
        }

        public void AddLowerLeftCorner()
        {
            Right = true;
            Up = true;
        }

        public void AddLowerRightCorner()
        {
            Left = true;
            Up = true;
        }

        public void AddUpperLeftCorner()
        {
            Down = true;
            Right = true;
        }

        public void AddUpperRightCorner()
        {
            Down = true;
            Left = true;
        }
        
    }
}
