using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Deadline6SecondTry.Entities
{
    public class Group: Entity
    {   
        public int? BossStudentId { get; set; }

        [JsonIgnore]

        public Student BossStudent { get; set; }

        public string GroupName { get; set;}

        [JsonIgnore]

        public List<Student> students { get; set; }

        public int CafedreId { get; set; }

        [JsonIgnore]

        public Cafedre Cafedre { get; set; }
    }
}
