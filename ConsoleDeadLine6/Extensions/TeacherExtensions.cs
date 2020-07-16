using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleDeadLine6.Models;

namespace ConsoleDeadLine6.Extensions
{
    public static class TeacherExtensions
    {
        public static List<Teacher> DepartmentSort(this List<Teacher> teachers, bool check)
        {
            if (check)
                return teachers.OrderBy(i => i.Cafedre.Department.DepartmentName).ToList();
            return teachers;
        }

        public static List<Teacher> FIOSort(this List<Teacher> teachers, bool check)
        {
            if (check)
            {
                return teachers.OrderBy(i => i.Human.FirstName + i.Human.MiddleName + i.Human.LastName).ToList();
            }

            return teachers;
        }

        public static List<Teacher> CafedreSort(this List<Teacher> teachers, bool check)
        {
            if (check)
            {
                return  teachers.OrderBy(i => i.Cafedre.CafedreName).ToList();
            }
            return teachers;
        }
    }
}
