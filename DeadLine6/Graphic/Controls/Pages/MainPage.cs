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
            
            GraphicListControl graphic = new GraphicListControl(new Point(5,5), new List<string> (new string[]{ "Создать группу", "Создать кафедру","Внести нового человека", "Внести студента", "Внести преподавателя", "Поиск"}), ControlType.Button, ListLine.Vertical);
            controls.Add(graphic);
        }
        public override void Draw()
        {
            foreach (var control in controls)
            {
                control.Draw();   
            }
        }

        public override void Action()
        {
            Marker marker = new Marker(controls[0], "*");
            marker.Action();
        }

        public void GotoDepartmentCreatePage()
        {
            Console.Clear();
            
        }
    }
}
