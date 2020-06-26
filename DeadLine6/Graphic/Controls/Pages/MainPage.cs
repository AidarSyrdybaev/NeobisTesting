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
            
            controls.Add(new Button(new Point(50,2), "Добавить студента"));
            controls.Add(new Button(new Point(50, 3), "Добавить группу"));
            controls.Add(new Button(new Point(50, 4), "Добавить Кафедру"));
            controls.Add(new Button(new Point(50, 5), "Добавить Учителя"));
            controls[0].SetControlsNav(controls[0], controls[0], controls[3], controls[1]);
            controls[1].SetControlsNav(controls[1], controls[1], controls[0], controls[2]);
            controls[2].SetControlsNav(controls[2], controls[2], controls[1], controls[3]);
            controls[3].SetControlsNav(controls[3], controls[3], controls[2], controls[0]);
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
    }
}
