using DeadLine6.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeadLine6.Repositories
{
    public class DepartmentRepository: Repository<Department>
    {
        public DepartmentRepository(string Path): base(Path)
        { 
        
        }
    }
}
