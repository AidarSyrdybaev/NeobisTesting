using DeadLine6.Graphic.Controls;
using DeadLine6.Graphic.Elements;
using DeadLine6.Models;
using System;
using System.Collections.Generic;

namespace DeadLine6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new string('A', 20));
            Table<Group> table = new Table<Group>(new Point(1,1));
            table.ColumnIntevral = 20;
            table.RowInterval = 5;
            List<Group> groups = new List<Group>();
            table.ActionDrawRows = Groups;
            table.SetColumnName("GroupName", "DepartmentId");
            groups.Add(new Group { GroupName = "Hello", DepartmentId = 1 });
            groups.Add(new Group { GroupName = "Hello", DepartmentId = 1 });
            groups.Add(new Group { GroupName = "Hello", DepartmentId = 1 });
            groups.Add(new Group { GroupName = "Hello", DepartmentId = 1 });
            groups.Add(new Group { GroupName = "Hello", DepartmentId = 1 });
            groups.Add(new Group { GroupName = "Hello", DepartmentId = 1 });
            table.objects = groups;
            table.Draw();
        }

        public static void Groups(object Group, int ColumnInterval, int RowInterval)
        {
            var group = (Group)Group;
            Console.Write(group.GroupName + new string(' ', ColumnInterval-group.GroupName.Length) + group.DepartmentId);
        }
    }
}
