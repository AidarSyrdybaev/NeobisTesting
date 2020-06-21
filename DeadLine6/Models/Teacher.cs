using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeadLine6.Models
{   
    public enum TeacherPosition
    {
        Teacher,
        Leader
    }
    public class Teacher: Entity
    {
        public int HumanId { get; set; }

        [JsonIgnore]

        public Human Human { get; set; }

        public int DepartmentId { get; set; }

        [JsonIgnore]

        public Department Department { get; set; }

        public TeacherPosition TeacherPosition { get; set; }
    }
}
