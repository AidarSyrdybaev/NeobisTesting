using DeadLine6.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeadLine6.Repositories
{
    public class GroupRepository: Repository<Group>
    {
        public GroupRepository(string Path) : base(Path)
        {

        }
    }
}
