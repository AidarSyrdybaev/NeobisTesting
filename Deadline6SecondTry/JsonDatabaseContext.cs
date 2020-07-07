using Deadline6SecondTry.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deadline6SecondTry
{
    public class JsonDatabaseContext
    {
        private static string GenericPath = "../../JsonData/";
        public DepartmentRepository Departments { get; }

        public GroupRepository Groups { get; }

        public HumanRepository Humans { get; }

        public StudentRepository Students { get; }

        public TeacherRepository Teachers { get; }

        public JsonDatabaseContext()
        {
            Departments = new DepartmentRepository(string.Concat(GenericPath, "Departments.json"));
            Groups = new GroupRepository(string.Concat(GenericPath, "Groups.json"));
            Humans = new HumanRepository(string.Concat(GenericPath, "Humans.json"));
            Students = new StudentRepository(string.Concat(GenericPath, "Students.json"));
            Teachers = new TeacherRepository(string.Concat(GenericPath, "Teachers.json"));
        }
    }
}
