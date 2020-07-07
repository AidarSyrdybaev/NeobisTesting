using Deadline6SecondTry.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deadline6SecondTry.Repositories
{
    public class GroupRepository: Repository<Group>
    {
        public GroupRepository(string Path) : base(Path)
        {

        }
    }
}
