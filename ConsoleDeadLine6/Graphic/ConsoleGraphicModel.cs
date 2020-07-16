using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using ConsoleDeadLine6.Extensions;
using ConsoleDeadLine6.Models;

namespace ConsoleDeadLine6.Graphic
{
    public class ConsoleGraphicModel
    {
        private static int IntervalString = 20;
        static List<Department> _departments = new List<Department>();
        static List<Cafedre> _cafedres = new List<Cafedre>();
        static List<Human> _humans = new List<Human>();
        static List<Student> _students = new List<Student>();
        static List<Teacher> _teachers = new List<Teacher>();
        static List<Group> _groups = new List<Group>();
        public ConsoleGraphicModel(List<Department> departments, List<Cafedre> cafedres, List<Human> Humans, List<Student> students, List<Teacher> teachers, List<Group> groups)
        {
            _humans = Humans;
            _cafedres = cafedres;
            _students = students;
            _teachers = teachers;
            _departments = departments;
            _groups = groups;
        }

        public void IntefaceDraw()
        {
            Console.WriteLine("Ваши действия:");
            Console.WriteLine("1. Сортировка студентов");
            Console.WriteLine("2. Сортировка учителей");
            Console.WriteLine("3. Выход");
            Console.WriteLine("4. Ничего");

        }

        public void Work()
        {
          
            while (true)
            {   
                Console.Clear();
                Draw();
                bool WorkCheck = Action();
                if (!WorkCheck)
                    break;

            }
        }

        public void StudentSortGraphic()
        {
            bool DSortCheck = GetAnswer("включить сортировку по факультету");
            bool GSortCheck = GetAnswer("включить сортировку по группе");
            bool FIOSortCheck = GetAnswer("включить сортировку по ФИО");
            bool CSortCheck = GetAnswer("включить сортировку по кафедре");
            _students = _students.DepartmentSort(DSortCheck).GroupSort(GSortCheck).FIOSort(FIOSortCheck).CafedreSort(CSortCheck);
        }

        public void TeacherSortGraphic()
        {
            bool DSortCheck = GetAnswer("включить сортировку по факультету");
            bool FIOSortCheck = GetAnswer("включить сортировку по ФИО");
            bool CSortCheck = GetAnswer("включить сортировку по кафедре");
            
            _teachers = _teachers.DepartmentSort(DSortCheck).FIOSort(FIOSortCheck).CafedreSort(CSortCheck);
        }

        public bool GetAnswer(string Question)
        {   
            Console.WriteLine(Question + "  Y/N?");
            string Answer = Console.ReadLine();
            if (Answer.ToUpper() != "Y" && Answer.ToUpper() != "N")
            {
                Console.WriteLine("некорректный вариант");
                return GetAnswer(Question);
            }
            else if (Answer.ToUpper() == "Y")
                return true;
            else
                return false;
        }

        public void StudentsDraw()
        {   
            Console.WriteLine("Список всех студентов");
            Console.WriteLine(GetIntervalString("Имя")+GetIntervalString("Фамилия")+GetIntervalString("Отчество")+GetIntervalString("Факультет")+GetIntervalString("Группа")+GetIntervalString("Наименовние кафедры"));
            foreach (var student in _students)
            {
                 StudentDraw(student);
            }
        }

        public void TeachersDraw()
        {   
            Console.WriteLine("Список всех учителей");
            Console.WriteLine(GetIntervalString("Имя") + GetIntervalString("Фамилия") + GetIntervalString("Отчество") + GetIntervalString("Наименовние кафедры"));
            foreach (var teacher in _teachers)
            {
                TeacherDraw(teacher);
            }
        }

        public void ManagerCafedreDraw()
        {
            Console.WriteLine("Список всех заведующих");
            Console.WriteLine(GetIntervalString("Имя") + GetIntervalString("Фамилия") + GetIntervalString("Отчество") + GetIntervalString("Наименовние кафедры"));
            foreach (var teacher in _teachers)
            {   
                if(teacher.TeacherPosition == TeacherPosition.Leader)
                    TeacherDraw(teacher);
            }
        }

        private void ManagerGroupDraw()
        {
            Console.WriteLine("Список всех старост");
            Console.WriteLine(GetIntervalString("Имя") + GetIntervalString("Фамилия") + GetIntervalString("Отчество") + GetIntervalString("Факультет") + GetIntervalString("Группа") + GetIntervalString("Наименовние кафедры"));
         
            foreach (var student in _students)
            {
                if (student.StudentPosition == StudentPosition.Elder)
                {   
                    StudentDraw(student);
                }
            }
        }



        private string GetIntervalString(string Word)
        {
            string Interval = string.Empty;
            for (int i = 0; i < IntervalString - Word.Length; i++)
            {
                Interval += " ";
            }

            return Word + Interval;
        }

        private void HumanDraw(Human Human)
        {
            Console.Write(GetIntervalString(Human.FirstName) + GetIntervalString(Human.MiddleName) +
                              GetIntervalString(Human.LastName));
        }

        private void StudentDraw(Student student)
        {
            HumanDraw(student.Human);
            Console.WriteLine(GetIntervalString(student.Group.Cafedre.Department.DepartmentName) + GetIntervalString(student.Group.GroupName) + GetIntervalString(student.Group.Cafedre.CafedreName));
        }

        private void TeacherDraw(Teacher teacher)
        {
            HumanDraw(teacher.Human);
            Console.WriteLine(teacher.Cafedre.CafedreName);

        }

        private void DrawFreeGroupAndCafedre()
        {   
            Console.WriteLine("Список кафедры без заведующих");
            foreach (var VARIABLE in _cafedres)
            {   
                if(VARIABLE.BossTeacher == null)
                    Console.WriteLine(GetIntervalString(VARIABLE.CafedreName));
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Список групп без староост");
            foreach (var VARIABLE in _groups)
            {   
                if(!VARIABLE.BossStudentId.HasValue)
                    Console.WriteLine(VARIABLE.GroupName);
            }
            
        }

        private bool Action()
        {
            int Number = GetNumberToString();
            switch (Number)
            {
                case 1:
                    StudentSortGraphic();
                    break;
                case 2:
                    TeacherSortGraphic();
                    break;
                case 3:
                    return false;
                case 4:
                    return true;
                default:
                    Console.WriteLine("Такой команды нет");
                    return Action();
            }

            return true;
        }

        private int GetNumberToString()
        {
            string Txt = Console.ReadLine();
            if (int.TryParse(Txt, out int numbeResult));
            {
                return numbeResult;
            }
            Console.WriteLine("Неверный ввод, повторите еще раз");
            return GetNumberToString();
        }

        private void Draw()
        {
            
            
            StudentsDraw();
            Console.WriteLine();
            TeachersDraw();
            Console.WriteLine();
            ManagerCafedreDraw();
            Console.WriteLine();
            ManagerGroupDraw();
            Console.WriteLine();
            DrawFreeGroupAndCafedre();
            Console.WriteLine();
            IntefaceDraw();
        }
    }
}
