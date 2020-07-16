using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleDeadLine6.Graphic;
using ConsoleDeadLine6.Models;

namespace ConsoleDeadLine6
{
    class Program
    {
        static List<Department> departments = new List<Department>();
        static List<Cafedre> cafedres = new List<Cafedre>();
        static List<Human> Humans = new List<Human>();
        static List<Student> students = new List<Student>();
        static List<Teacher> teachers = new List<Teacher>();
        static List<Group> groups = new List<Group>();
        static void Main(string[] args)
        {

            DeparmentFill();
            HumanFill();
            CafedreFill();
            GroupFill();
            ConsoleGraphicModel _console = new ConsoleGraphicModel(departments, cafedres, Humans, students, teachers, groups);
            _console.Work();
        }

        private static void DeparmentFill()
        {
            departments.Add(new Department { Id = 1, DepartmentName = "Финансы" });
            departments.Add(new Department { Id = 2, DepartmentName = "Врачебное дело" });
        }

        private static void GroupFill()
        {
            groups.Add(new Group{Id = 1,CafedreId = 1, GroupName = "Группа1"});
            groups.Add(new Group { Id = 2, CafedreId = 2, GroupName = "Группа2", BossStudentId = 1});
            students[0].StudentPosition = StudentPosition.Elder;
            foreach (var group in groups)
            {   
                if(group.BossStudentId.HasValue)
                    group.BossStudent = students.FirstOrDefault(i => i.Id == group.BossStudentId.Value);
                group.Cafedre = cafedres.FirstOrDefault(i => i.Id == group.CafedreId);
            }
            foreach (var student in students)
                student.Group = groups.FirstOrDefault(i => i.Id == student.GroupId);
            foreach (var teacher in teachers)
            {
                teacher.Cafedre = cafedres.FirstOrDefault(i => i.Id == teacher.CafedreId);
            }

        }

        private static void HumanFill()
        {
            foreach (int i in Enumerable.Range(1, 20))
            {
                var Human = new Human
                {
                    Id = i,
                    FirstName = $"{i}",
                    LastName = $"{i}",
                    MiddleName = $"{i}",
                    Address = $"{i}",
                    DateBorn = DateTime.Now,
                    PassportId = i,

                };
                bool IsStudent = false;
                bool IsTeacher = false;
                if (i % 3 == 0)
                {
                    IsTeacher = true;
                    var Teacher = new Teacher
                        {Id = i, HumanId = i, CafedreId = (i % 2) + 1, TeacherPosition = TeacherPosition.Teacher};
                    Teacher.Human = Human;
                    teachers.Add(Teacher);
                }
                else
                {
                    IsStudent = true;
                    var Student = new Student
                        {Id = i, GroupId = (i % 2) + 1, HumanId = i, StudentPosition = StudentPosition.Student};
                    Student.Human = Human;
                    students.Add(Student);
                }
                Humans.Add(Human);
                Human.IsTeacher = IsTeacher;
                Human.IsStudent = IsStudent;
                
            }
            Humans[0].IsTeacher = true;
        }

        private static void CafedreFill()
        {
            cafedres.Add(new Cafedre{CafedreName = "Бухгалтерия", DepartmentId = 1, TeacherBossId = 1, IsProfile = true, Id = 1});
            cafedres.Add(new Cafedre { CafedreName = "Стоматология", DepartmentId = 2, TeacherBossId = 3, IsProfile = true, Id = 2 });
            cafedres.Add(new Cafedre { CafedreName = "Психология", DepartmentId = 2, TeacherBossId = 6, IsProfile = false, Id = 3 });
            cafedres.Add(new Cafedre { CafedreName = "Хорошисты", DepartmentId = 2, IsProfile = false, Id = 3 });
            teachers[0].TeacherPosition = TeacherPosition.Leader;
            teachers[1].TeacherPosition = TeacherPosition.Leader;
            teachers[2].TeacherPosition = TeacherPosition.Leader;
            foreach (var cafedre in cafedres)
            {
                cafedre.Department = departments.FirstOrDefault(i => i.Id == cafedre.DepartmentId);
                cafedre.BossTeacher = teachers.FirstOrDefault(i => i.Id == cafedre.TeacherBossId);
            }
        }
    }
}
