using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDeadLine6.Models
{
    public class Cafedre: Entity
    {
        public int? TeacherBossId { get; set; }

        public Teacher BossTeacher { get; set; }

        public string CafedreName { get; set; }

        public bool IsProfile { get; set; }

        public List<Teacher> Teachers { get; set; }

        public List<Group> Groups { get; set; }

        public int DepartmentId { get; set; }

        public Department Department { get; set; }
    }
}
