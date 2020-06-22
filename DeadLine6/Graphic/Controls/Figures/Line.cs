using DeadLine6.Graphic.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeadLine6.Graphic.Controls.Figures
{
    public enum LineType { 
        Vertical,
        Horizontal
    }
    public class Line: Figure
    {   
        LineType LineType { get; set; }
        int Length { get; set; }
        public Line(Point point, LineType _LineType, int _Length, string _Mark) : base(point)
        {
            LineType = _LineType;
            Length = _Length;
            Mark = _Mark;
        }

        public override void Draw()
        {
            base.Draw();
            int XAdd = LineType == LineType.Horizontal ? 1 : 0;
            int YAdd = LineType == LineType.Vertical ? 1 : 0;
            for (int i = 0; i < Length; i++)
            {
                base.Draw(XAdd*i, YAdd*i);
                Console.Write(Mark);
            }
            
        }
    }
}
