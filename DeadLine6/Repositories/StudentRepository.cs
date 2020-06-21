using DeadLine6.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeadLine6.Repositories
{
    public class StudentRepository: Repository<Student>
    {
        public StudentRepository(string Path) : base(Path)
        { 
        
        }
    }
}
