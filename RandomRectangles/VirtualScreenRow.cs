using System;
using System.Collections.Generic;
using System.Text;

namespace RandomRectangles
{
    class VirtualScreenRow
    {
        private VirtualScreenCell[] _row;

        public VirtualScreenRow(int width)
        {
            _row = new VirtualScreenCell[width];
            for (int i = 0; i < width; i++)
            {
                _row[i] = new VirtualScreenCell();
            }
        }

        public void AddBoxTopRow(int boxX, int boxWidth)
        {
            _row[boxX].AddUpperLeftCorner();
            for (var i = 1; i < boxWidth -1; i++)
            {
                _row[boxX + i].AddHorizontal();
            }
            _row[boxX + boxWidth - 1].AddUpperRightCorner();
        }

        public void AddBoxBottomRow(int boxX, int boxWidth)
        {
            _row[boxX].AddLowerLeftCorner();
            for (var i = 1; i < boxWidth - 1; i++)
            {
                _row[boxX + i].AddHorizontal();
            }
            _row[boxX + boxWidth -1].AddLowerRightCorner();
        }

        public void AddBoxMiddleRow(int boxX, int boxWidth)
        {
            _row[boxX].AddVertical();
            _row[boxX + boxWidth - 1].AddVertical();
        }

        public void Show()
        {
            foreach (var cell in _row)
            {
                Console.Write(cell.GetCharacter());
            }
            Console.WriteLine();
        }

    }
}
