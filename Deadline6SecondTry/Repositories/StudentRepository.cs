using Deadline6SecondTry.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deadline6SecondTry.Repositories
{
    public class StudentRepository: Repository<Student>
    {
        public StudentRepository(string Path) : base(Path)
        { 
        
        }
    }
}
