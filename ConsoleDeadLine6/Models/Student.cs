
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDeadLine6.Models
{
    public enum StudentPosition
    {   
        Student,
        Elder
    }
    public class Student: Entity
    {
        public int HumanId { get; set; }

        public Human Human { get; set; }

        public int GroupId { get; set; }

        public Group Group { get; set; }

        public StudentPosition StudentPosition {get;set;}
    }
}
