using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeadLine6.Models
{
    public enum StudentPosition
    {   
        Student,
        Elder
    }
    public class Student: Entity
    {
        public int HumanId { get; set; }

        [JsonIgnore]

        public Human Human { get; set; }

        public int GroupId { get; set; }

        [JsonIgnore]

        public Group Group { get; set; }

        public StudentPosition StudentPosition {get;set;}
    }
}
