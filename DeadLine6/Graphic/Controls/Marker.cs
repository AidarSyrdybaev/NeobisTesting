using DeadLine6.Graphic.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeadLine6.Graphic.Controls
{
    public class Marker
    {
        Control SelectedControl;
        string Mark;

        public Marker(Control control, string _mark)
        {
            SelectedControl = control;
            Mark = _mark;
        }

        public void Draw()
        {
            Console.SetCursorPosition(SelectedControl.Point.PositionX - 3, SelectedControl.Point.PositionY);
            Console.Write(Mark);
        }

        public void Action()
        {
            Draw();
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo consoleKeyinfo = Console.ReadKey();
                    Clear();
                    switch (consoleKeyinfo.Key)
                    {
                        case ConsoleKey.Enter:
                            SelectedControl.Action();
                            break;
                        case ConsoleKey.UpArrow:
                            SelectedControl = SelectedControl.ControlUp;
                            break;
                        case ConsoleKey.DownArrow:
                            SelectedControl = SelectedControl.ControlDown;
                            break;
                        case ConsoleKey.LeftArrow:
                            SelectedControl = SelectedControl.ControlLeft;
                            break;
                        case ConsoleKey.RightArrow:
                            SelectedControl = SelectedControl.ControlRight;
                            break;
                    }
                    Draw();
                }
            }
        }

        public void Clear()
        {
            Console.SetCursorPosition(SelectedControl.Point.PositionX - 3, SelectedControl.Point.PositionY);
            Console.Write(" ");
        }

    }
}
