
using System;
using System.Collections.Generic;
using System.Text;
using Deadline6SecondTry.Entities;

namespace Deadline6SecondTry.Repositories
{
    public class DepartmentRepository: Repository<Department>
    {
        public DepartmentRepository(string Path): base(Path)
        { 
        
        }
    }
}
