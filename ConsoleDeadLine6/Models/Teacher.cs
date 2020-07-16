using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDeadLine6.Models
{   
    public enum TeacherPosition
    {
        Teacher,
        Leader
    }
    public class Teacher: Entity
    {
        public int HumanId { get; set; }

        public Human Human { get; set; }

        public int CafedreId { get; set; }

        public Cafedre Cafedre { get; set; }

        public TeacherPosition TeacherPosition { get; set; }
    }
}
