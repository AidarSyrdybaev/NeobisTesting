using DeadLine6.Graphic.Controls;
using DeadLine6.Graphic.Controls.Pages;
using DeadLine6.Graphic.Elements;
using DeadLine6.Models;
using System;
using System.Collections.Generic;

namespace DeadLine6
{
    class Program
    {
        static void Main(string[] args)
        {   
            JsonDatabaseContext jsonDatabaseContext = new JsonDatabaseContext();
            Page page = new HumanCreatePage(jsonDatabaseContext);
            page.Draw();
            page.Action();
        }

    }
}
