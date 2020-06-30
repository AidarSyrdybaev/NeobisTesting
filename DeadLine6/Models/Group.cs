using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace DeadLine6.Models
{
    public class Group: Entity
    {   
        public int? BossStudentId { get; set; }

        [JsonIgnore]

        public Student BossStudent { get; set; }

        public string GroupName { get; set;}

        [JsonIgnore]

        public List<Student> students { get; set; }

        public int DepartmentId { get; set; }

        [JsonIgnore]

        public Department Department { get; set; }
    }
}
