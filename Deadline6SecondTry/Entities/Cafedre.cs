using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Deadline6SecondTry.Entities
{
    public class Cafedre: Entity
    {
        public int? TeacherBossId { get; set; }

        [JsonIgnore]

        public Teacher BossTeacher { get; set; }

        public string CafedreName { get; set; }

        public bool IsProfile { get; set; }

        [JsonIgnore]

        public List<Teacher> Teachers { get; set; }

        [JsonIgnore]

        public List<Group> Groups { get; set; }

        public int DepartmentId { get; set; }

        public Department Department { get; set; }
    }
}
