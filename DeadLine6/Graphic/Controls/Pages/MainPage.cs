using System;
using System.Collections.Generic;
using DeadLine6.Graphic.Elements;
using System.Text;

namespace DeadLine6.Graphic.Controls.Pages
{
    public class MainPage : Page
    {
    
        

        public MainPage(JsonDatabaseContext jsonDatabaseContext) : base(jsonDatabaseContext)
        { 
        
        }

        public override void SetGraphics()
        {   
            Label labelMainMenu = new Label(new Point(2,2), "Основное меню:"); 
            GraphicListControl graphic = new GraphicListControl(new Point(7,3), new List<string> (new string[]{ "Создать группу", "Создать кафедру","Создать нового человека", "Внести студента", "Внести преподавателя", "Поиск"}), ControlType.Button, ListLine.Vertical);
            UseControls.Add(graphic);
            DrawControls.Add(labelMainMenu);

            
        }
        public override void Draw()
        {
            base.Draw();
        }

        public override void Action()
        {
            UseControls[0].Action();
        }

        public void GotoDepartmentCreatePage()
        {
            Console.Clear();
        }
    }
}
