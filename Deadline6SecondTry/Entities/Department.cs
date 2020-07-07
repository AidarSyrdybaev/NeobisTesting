using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deadline6SecondTry.Entities
{
    public class Department: Entity
    {   
        public string DepartmentName { get; set; }
        [JsonIgnore]
        public List<Cafedre> Cafedres { get; set; }
    }
}
