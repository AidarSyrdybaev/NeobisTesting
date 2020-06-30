using System;
using System.Collections.Generic;
using System.Text;
using DeadLine6.Graphic.Elements;

namespace DeadLine6.Graphic.Controls
{
    public class Label: Control
    {
        public Label(Point point, string TxtValue):base(point)
        {
            this.TxtValue = TxtValue;
        }

        public override void Draw()
        {   
            base.Draw();
            Console.Write(TxtValue);
        }
    }
}
