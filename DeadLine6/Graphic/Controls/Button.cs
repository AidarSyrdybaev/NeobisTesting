using DeadLine6.Graphic.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeadLine6.Graphic.Controls
{
    public class Button : Control
    {   

        
        public Action ButtonPressEvent{ get; set; }

        public Button(Point point) : base(point)
        {
           
        }

        public Button(Point point, string Text): this(point)
        {
            TxtValue = Text;
        }

        public override void Action()
        {
            ButtonPressEvent?.Invoke();
        }

        public override void Draw()
        {   
            base.Draw();
            Console.WriteLine(TxtValue);
        }
    }
}
