using DeadLine6.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeadLine6.Repositories
{
    public class HumanRepository: Repository<Human>
    {
        public HumanRepository(string path): base(path)
        { 
            
        }
    }
}
