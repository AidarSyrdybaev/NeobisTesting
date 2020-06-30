using DeadLine6.Graphic.Elements;
using System;
using System.Collections.Generic;
using System.Text;
using DeadLine6.Models;

namespace DeadLine6.Graphic.Controls.Pages
{
    public class GroupCreatePage : Page
    {
        public GroupCreatePage(JsonDatabaseContext jsonDatabaseContext) : base(jsonDatabaseContext)
        {

        }

        public override void Action()
        {
            Marker marker = new Marker(controls[2], "*");
            marker.Action();
        }

        public override void SetGraphics()
        {
            Label label = new Label(new Point(16, 1), "Меню создания группы");
            Label labelMainMenu = new Label(new Point(3, 4), "Введите название группы: ");
            TextBox GroupNameTxtBx = new TextBox(new Point(37, 4));
            Label label2 = new Label(new Point(3, 5), "Введите Id кафедры: ");
            TextBox DepartmentIdTxtBx = new TextBox(new Point(37, 5));
            Button GroupCreateBtn = new Button(new Point(37, 6));
            GroupCreateBtn.TxtValue = "Создать группу";
            DepartmentIdTxtBx.LettersPad = false;
            GroupNameTxtBx.SetControlsNav(GroupNameTxtBx, GroupNameTxtBx, GroupCreateBtn, DepartmentIdTxtBx);
            DepartmentIdTxtBx.SetControlsNav(DepartmentIdTxtBx, DepartmentIdTxtBx, GroupCreateBtn, GroupCreateBtn);
            GroupCreateBtn.SetControlsNav(GroupCreateBtn, GroupCreateBtn, DepartmentIdTxtBx, GroupNameTxtBx);
            GroupCreateBtn.ActionEvent = GroupCreateAction;
            controls.Add(label);
            controls.Add(labelMainMenu);
            controls.Add(GroupNameTxtBx);
            controls.Add(label2);
            controls.Add(DepartmentIdTxtBx);
            controls.Add(GroupCreateBtn);

            void GroupCreateAction()
            {
                Group group = new Group {DepartmentId = int.Parse(DepartmentIdTxtBx.TxtValue), GroupName = GroupNameTxtBx.TxtValue};
                jsonDatabaseContext.Groups.Create(group);
            }
        }
    }
}
