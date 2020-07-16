
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDeadLine6.Models
{
    public class Department: Entity
    {   
        public string DepartmentName { get; set; }

        public List<Cafedre> Cafedres { get; set; }
    }
}
