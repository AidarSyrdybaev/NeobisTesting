using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ConsoleDeadLine6.Models;

namespace ConsoleDeadLine6.Extensions
{
    public static class StudentExtensions
    {
        public static List<Student> DepartmentSort(this List<Student> students, bool check)
        {
            if (check)
                return students.OrderBy(i => i.Group.Cafedre.Department.DepartmentName).ToList();
            return students;
        }

        public static List<Student> FIOSort(this List<Student> students, bool check)
        {
            if (check)
            {
                return students.OrderBy(i => i.Human.FirstName + i.Human.MiddleName + i.Human.LastName).ToList();
            }
            return students;
        }

        public static List<Student> GroupSort(this List<Student> students, bool check)
        {
            if (check)
            {
                return students.OrderBy(i => i.Group.GroupName).ToList();
            }
            return students;
        }

        public static List<Student> CafedreSort(this List<Student> students, bool check)
        {
            if (check)
            {
                return students.OrderBy(i => i.Group.Cafedre.CafedreName).ToList();
            }

            return students;
        }
    }
}
