using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DeadLine6.Graphic.Elements
{
    public struct Point
    {
        public int PositionX { get; set; }

        public  int PositionY { get; set; }
        public Point(int x, int y)
        {
            PositionX = x;
            PositionY = y;
        }
    }
}
