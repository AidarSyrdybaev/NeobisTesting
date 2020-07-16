using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDeadLine6.Models
{
   
    public class Human: Entity
    {
        public Human()
        {
            
        }


        public int PassportId { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public DateTime DateBorn { get; set; }

        public string Address { get; set; }

        public bool IsTeacher { get; set; }

        public bool IsStudent { get; set; }
    }
}
