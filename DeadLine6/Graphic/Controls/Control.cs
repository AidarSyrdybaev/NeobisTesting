using DeadLine6.Graphic.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeadLine6.Graphic.Controls
{
    public abstract class Control
    {
        public Point Point;

        public string TxtValue { get; set; }

        public Control ControlLeft;

        public Control ControlRight;

        public Control ControlUp;

        public Control ControlDown;

        public Control(Point _point)
        {
            Point = _point;
        }

        public virtual void Draw()
        {
            Console.SetCursorPosition(Point.PositionX, Point.PositionY);
        }

        public virtual void Draw(int X, int Y)
        {
            Console.SetCursorPosition(Point.PositionX + X, Point.PositionY + Y);
        }

        public virtual void Action()
        { 
            
        }

        public virtual void SetControlsNav(Control _controlLeft, Control _controlRight, Control _controlUp, Control _controlDown)
        {
            ControlLeft = _controlLeft;
            ControlRight = _controlRight;
            ControlUp = _controlUp;
            ControlDown = _controlDown;
        }

        public virtual void Clear()
        {
            Console.SetCursorPosition(Point.PositionX, Point.PositionY);
        }

        public virtual void InitializeControl()
        { 

        }
    }
}
