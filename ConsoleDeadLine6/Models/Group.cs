
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace ConsoleDeadLine6.Models
{
    public class Group: Entity
    {   
        public int? BossStudentId { get; set; }

        public Student BossStudent { get; set; }

        public string GroupName { get; set;}

        public List<Student> students { get; set; }

        public int CafedreId { get; set; }

        public Cafedre Cafedre { get; set; }
    }
}
