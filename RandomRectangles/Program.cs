using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace RandomRectangles
{
    class Program
    {
        private static int _width = 100;
        private static int _height = 50;
        private static Random random = new Random();

        static void Main(string[] args)
        {
            var boxes = CreateBoxes();
            while (true)
            {
                Show(boxes);
                Console.WriteLine("(press enter for new. ctrl+c=exit)");
                Console.ReadLine();
                //foreach (var box in boxes) box.Move(random, _width - 1, _height - 1);
                //Thread.Sleep(50);
            }
        }

        private static Box[] CreateBoxes()
        {
            var boxes = new Box[3];
            for (var i = 0; i < boxes.Length; i++)
            {
                boxes[i] = new Box(random, _width - 50, _height - 25);
            }
            return boxes;
        }

        private static void Show(Box[] boxes)
        {
            var screen = new VirtualScreen(_width, _height);
            foreach (var box in boxes)
            {
                screen.Add(box);
            }
            screen.Show();
        }
    }
}
