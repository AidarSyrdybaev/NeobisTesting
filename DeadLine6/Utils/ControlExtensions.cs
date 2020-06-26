using System;
using System.Collections.Generic;
using System.Text;
using DeadLine6.Graphic.Controls;
using DeadLine6.Graphic.Elements;

namespace DeadLine6.Utils
{
    public static class ControlExtensions
    {
        public static Control GetControlTypeObject(ControlType controlType, Point point)
        {
            switch (controlType)
            {
                case ControlType.Button:
                    return new Button(point);
                case ControlType.GraphicListControl:
                    return new GraphicListControl(point);
                case ControlType.RadioButton:
                    return new RadioButton(point);
                case ControlType.TextBox:
                    return new TextBox(point);
                default:
                    throw new Exception("Нет такого элемента управления");
            }
        }
    }
}
