using Deadline6SecondTry.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deadline6SecondTry.Repositories
{
    public class TeacherRepository: Repository<Teacher>
    {
        public TeacherRepository(string Path): base(Path)
        { 
            
        }
    }
}
