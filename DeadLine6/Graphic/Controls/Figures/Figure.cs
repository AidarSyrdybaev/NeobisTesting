using DeadLine6.Graphic.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeadLine6.Graphic.Controls.Figures
{
    public abstract class Figure: Control
    {   
        protected string Mark { get; set; }
        public Figure(Point point): base(point)
        {
            
        }
    }
}
