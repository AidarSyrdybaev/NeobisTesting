using System;
using System.Collections.Generic;
using System.Text;
using DeadLine6.Graphic.Elements;
using DeadLine6.Models;

namespace DeadLine6.Graphic.Controls.Pages
{
    public class DepartmentCreatePage : Page
    {
        public DepartmentCreatePage(JsonDatabaseContext jsonDatabaseContext) : base(jsonDatabaseContext)
        {
            
        }

        public override void Action()
        {
            base.Action();
        }

        public override void Draw()
        {
            base.Draw();
        }

        public override void SetGraphics()
        {   
            Label label = new Label(new Point(16,1),"Меню создания кафедры" );
            Label labelMainMenu = new Label(new Point(3, 4), "Введите наименование кафедры: ");
            TextBox DepartmentNameTxtBx = new TextBox(new Point(37, 4));
            RadioButton IsProfileChkBx = new RadioButton(new Point(37,5));
            Button DepartmentCreateBtn = new Button(new Point(37,6));
            DepartmentCreateBtn.ActionEvent = CreateDepartmentAction;
            DepartmentCreateBtn.TxtValue = "Создать кафедру";
            IsProfileChkBx.TxtValue = "Группа профильная";
            DrawControls.Add(labelMainMenu);
            UseControls.Add(DepartmentNameTxtBx);
            DrawControls.Add(IsProfileChkBx);
            UseControls.Add(DepartmentCreateBtn);
            DrawControls.Add(label);
            SetUseVerticalControlNavs();
            void CreateDepartmentAction()
            {
                Department department = new Department { DepartmentName = DepartmentNameTxtBx.TxtValue, IsProfile = IsProfileChkBx.Check};
                jsonDatabaseContext.Departments.Create(department);
            }
        }


    }
}
