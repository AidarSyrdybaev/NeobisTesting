using DeadLine6.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeadLine6.Repositories
{
    public class TeacherRepository: Repository<Teacher>
    {
        public TeacherRepository(string Path): base(Path)
        { 
            
        }
    }
}
