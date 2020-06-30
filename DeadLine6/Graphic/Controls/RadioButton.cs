using DeadLine6.Graphic.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeadLine6.Graphic.Controls
{
    public class RadioButton: Control
    {
        public RadioButton(Point point) : base(point)
        { 
        
        }
        public bool Check { get; set; }

        public override void Action()
        {
            Check = !Check;
            Clear();
            Draw();
            base.Action();
        }

        public override void Draw()
        {
            base.Draw();
            Console.Write(TxtValue + " " + Check.ToString());
        }

        public override void Clear()
        {
            base.Draw(TxtValue.Length, 0);
            Console.Write("      ");
        }
    }
}
