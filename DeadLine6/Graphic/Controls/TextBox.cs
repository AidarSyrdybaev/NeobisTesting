using DeadLine6.Graphic.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeadLine6.Graphic.Controls
{
    public class TextBox : Control
    {   
        public string TxtDecoration { get; set; }
        public string TxtValue { get; set; }
        public bool DigitsPad = true;
        public bool LettersPad = true;
        public TextBox(Point _point) : base(_point)
        {
            TxtValue = string.Empty;
        }

        public int SymbolLimit { get; set; }

        public override void Action()
        {
            
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo consoleKeyinfo = Console.ReadKey();
                    if (SymbolLimit > TxtValue.Length)
                    {
                        TxtValue += Keys(consoleKeyinfo.Key);
                    }
                    if (consoleKeyinfo.Key == ConsoleKey.Backspace)
                    {
                        if (TxtValue.Length > 0)
                        {
                            TxtValue = TxtValue.Remove(TxtValue.Length - 1);
                        }
                        
                    }
                    Draw();
                    if (consoleKeyinfo.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                    
                }
            }
        }

        public string Keys(ConsoleKey Key)
        {
            if (((int)Key > 64 && (int)Key < 91) ? LettersPad : false || ((int)Key > 95 && (int)Key < 106 || (int)Key > 47 && (int)Key < 58)? DigitsPad: false)
            {
                switch (Key)
                {
                    case ConsoleKey.Q:
                        return "q";
                    case ConsoleKey.W:
                        return "w";
                    case ConsoleKey.E:
                        return "e";
                    case ConsoleKey.R:
                        return "r";
                    case ConsoleKey.T:
                        return "t";
                    case ConsoleKey.Y:
                        return "y";
                    case ConsoleKey.U:
                        return "u";
                    case ConsoleKey.I:
                        return "i";
                    case ConsoleKey.O:
                        return "o";
                    case ConsoleKey.P:
                        return "p";
                    case ConsoleKey.A:
                        return "a";
                    case ConsoleKey.S:
                        return "s";
                    case ConsoleKey.D:
                        return "d";
                    case ConsoleKey.F:
                        return "f";
                    case ConsoleKey.G:
                        return "g";
                    case ConsoleKey.H:
                        return "h";
                    case ConsoleKey.J:
                        return "j";
                    case ConsoleKey.K:
                        return "k";
                    case ConsoleKey.L:
                        return "l";
                    case ConsoleKey.Z:
                        return "z";
                    case ConsoleKey.X:
                        return "x";
                    case ConsoleKey.C:
                        return "c";
                    case ConsoleKey.V:
                        return "v";
                    case ConsoleKey.B:
                        return "b";
                    case ConsoleKey.N:
                        return "n";
                    case ConsoleKey.M:
                        return "m";
                    case ConsoleKey.NumPad0:
                        return "0";
                    case ConsoleKey.NumPad1:
                        return "1";
                    case ConsoleKey.NumPad2:
                        return "2";
                    case ConsoleKey.NumPad3:
                        return "3";
                    case ConsoleKey.NumPad4:
                        return "4";
                    case ConsoleKey.NumPad5:
                        return "5";
                    case ConsoleKey.NumPad6:
                        return "6";
                    case ConsoleKey.NumPad7:
                        return "7";
                    case ConsoleKey.NumPad8:
                        return "8";
                    case ConsoleKey.NumPad9:
                        return "9";
                    case ConsoleKey.D0:
                        return "0";
                    case ConsoleKey.D1:
                        return "1";
                    case ConsoleKey.D2:
                        return "2";
                    case ConsoleKey.D3:
                        return "3";
                    case ConsoleKey.D4:
                        return "4";
                    case ConsoleKey.D5:
                        return "5";
                    case ConsoleKey.D6:
                        return "6";
                    case ConsoleKey.D7:
                        return "7";
                    case ConsoleKey.D8:
                        return "8";
                    case ConsoleKey.D9:
                        return "9";

                }
            }

            return string.Empty;
        }

        public override void Draw()
        {
            base.Draw();
            Console.Write(new string(' ', TxtValue.Length+1));
            base.Draw();
            Console.Write(TxtValue);
        }

        public string Clear(int Count)
        {
            return new string(' ', Count);
        }
    }
}
