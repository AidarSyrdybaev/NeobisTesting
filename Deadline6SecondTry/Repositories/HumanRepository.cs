using Deadline6SecondTry.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deadline6SecondTry.Repositories
{
    public class HumanRepository: Repository<Human>
    {
        public HumanRepository(string path): base(path)
        { 
            
        }
    }
}
