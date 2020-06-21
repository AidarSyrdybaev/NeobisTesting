using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeadLine6.Models
{
    public class Department: Entity
    {   
        public string DepartmentName { get; set; }

        public bool IsProfile { get; set; }

        [JsonIgnore]

        public List<Teacher> Teachers { get; set; }

        [JsonIgnore]

        public List<Group> Groups { get; set; }
    }
}
