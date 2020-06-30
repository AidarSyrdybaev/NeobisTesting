using DeadLine6.Graphic.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeadLine6.Graphic.Controls.Pages
{
    public class HumanCreatePage : Page
    {
        public HumanCreatePage(JsonDatabaseContext jsonDatabaseContext) : base(jsonDatabaseContext)
        {

        }

        public override void Action()
        {
            base.Action();

        }
    

        public override void SetGraphics()
        {
            Label labelFirstName = new Label(new Point(3, 4), "Введите Имя: ");
            TextBox HumanFirstNameTxtBx = new TextBox(new Point(37, 4));
            Label labelMiddleName = new Label(new Point(3, 5), "Введите Отчество: ");
            TextBox HumanMiddleNameTxtBx = new TextBox(new Point(37, 5));
            Label labelLastName = new Label(new Point(3, 6), "Введите Фамилию: ");
            TextBox HumanLastNameTxtBx = new TextBox(new Point(37, 6));
            Label labelPassportId = new Label(new Point(3, 7), "Введите ID паспорта: ");
            TextBox HumanPassportIdTxtBx = new TextBox(new Point(37, 7));
            Label labelDayBorn = new Label(new Point(3, 8), "Введите день рождения: ");
            TextBox DayBornTxtBox = new TextBox(new Point(37, 8));
            Label labelMonthBorn = new Label(new Point(3, 9), "Введите месяц рождения: ");
            TextBox MonthBornTxtBox = new TextBox(new Point(37, 9));
            Label labelYearBorn = new Label(new Point(3, 10), "Введите год рождения: ");
            TextBox YearBornTxtBox = new TextBox(new Point(37, 10));
            Label labelAdress = new Label(new Point(3, 11), "Введите адресс: ");
            TextBox AdressTxtBox = new TextBox(new Point(37, 11));
            RadioButton IsTeacherRbtn = new RadioButton(new Point(25, 12));
            RadioButton IsStudentRbtn = new RadioButton(new Point(25, 13));
            HumanPassportIdTxtBx.LettersPad = false;
            DayBornTxtBox.LettersPad = false;
            MonthBornTxtBox.LettersPad = false;
            YearBornTxtBox.LettersPad = false;
            IsTeacherRbtn.TxtValue = "Это учитель: ";
            IsStudentRbtn.TxtValue = "Это студент: ";

           
            DrawControls.Add(labelFirstName);
            UseControls.Add(HumanFirstNameTxtBx);
            DrawControls.Add(labelMiddleName);
            UseControls.Add(HumanMiddleNameTxtBx);
            DrawControls.Add(labelLastName);
            UseControls.Add(HumanLastNameTxtBx);
            DrawControls.Add(labelPassportId);
            UseControls.Add(HumanPassportIdTxtBx);
            DrawControls.Add(labelDayBorn);
            UseControls.Add(DayBornTxtBox);
            DrawControls.Add(labelMonthBorn);
            UseControls.Add(MonthBornTxtBox);
            DrawControls.Add(labelYearBorn);
            UseControls.Add(YearBornTxtBox);
            UseControls.Add(IsTeacherRbtn);
            UseControls.Add(IsStudentRbtn);
            SetUseVerticalControlNavs();
        }
    }
}
