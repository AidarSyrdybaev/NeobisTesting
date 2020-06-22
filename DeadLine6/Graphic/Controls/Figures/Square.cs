using DeadLine6.Graphic.Elements;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace DeadLine6.Graphic.Controls.Figures
{
    public class Square: Figure
    {   
        List<Line> lines { get; set; }
        public Square(Point point, int Width, int Length) : base(point)
        {
            
            lines = new List<Line>();
            lines.Add(new Line(point, LineType.Horizontal, Length, "-"));
            lines.Add(new Line(point, LineType.Vertical, Width, "|"));
            lines.Add(new Line(new Point(point.PositionX, point.PositionY+Width-1), LineType.Horizontal, Length, "_"));
            lines.Add(new Line(new Point(point.PositionX+Length-1, point.PositionY), LineType.Vertical, Width, "|"));
        }

        public override void Draw()
        {
            foreach (var line in lines)
            {
                line.Draw();
            }
        }
    }
}
