using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DeadLine6.Utils
{
    public class KeypadLine
    {
        public int SymbolLimit { get; set; }

        //public string PrintText()
        //{
        //    int SymbolCount = 0;
        //    string Text = string.Empty;
        //    while (true)
        //    {
        //        if (Console.KeyAvailable)
        //        {
        //            ConsoleKeyInfo consoleKeyinfo = Console.ReadKey();
        //            if (consoleKeyinfo.Key.ToString().Length == 1 && char.IsLetterOrDigit(consoleKeyinfo.Key.ToString()[0]) && SymbolLimit < SymbolCount)
        //            {   
        //                Text += Keys(consoleKeyinfo.Key).ToString();
        //                SymbolCount++;
        //            }
        //            if (consoleKeyinfo.Key == ConsoleKey.Enter)
        //            {
        //                break;
        //            }
        //            if (consoleKeyinfo.Key == ConsoleKey.Backspace)
        //            {
        //                Text = Text.Remove(Text.Length-1);
        //            }
        //        }
        //    }
        //}

        public char Keys(ConsoleKey Key)
        {
            switch (Key)
            {
                case ConsoleKey.Q:
                    return 'q';
                case ConsoleKey.W:
                    return 'w';
                case ConsoleKey.E:
                    return 'e';
                case ConsoleKey.R:
                    return 'r';
                case ConsoleKey.T:
                    return 't';
                case ConsoleKey.Y:
                    return 'y';
                case ConsoleKey.U:
                    return 'u';
                case ConsoleKey.I:
                    return 'i';
                case ConsoleKey.O:
                    return 'o';
                case ConsoleKey.P:
                    return 'p';
                case ConsoleKey.A:
                    return 'a';
                case ConsoleKey.S:
                    return 's';
                case ConsoleKey.D:
                    return 'd';
                case ConsoleKey.F:
                    return 'f';
                case ConsoleKey.G:
                    return 'g';
                case ConsoleKey.H:
                    return 'h';
                case ConsoleKey.J:
                    return 'j';
                case ConsoleKey.K:
                    return 'k';
                case ConsoleKey.L:
                    return 'l';
                case ConsoleKey.Z:
                    return 'z';
                case ConsoleKey.X:
                    return 'x';
                case ConsoleKey.C:
                    return 'c';
                case ConsoleKey.V:
                    return 'v';
                case ConsoleKey.B:
                    return 'b';
                case ConsoleKey.N:
                    return 'n';
                case ConsoleKey.M:
                    return 'm';
                default:
                    return string.Empty[0];
            }
        }
    }
}
