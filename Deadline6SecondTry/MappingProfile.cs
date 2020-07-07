using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Deadline6SecondTry.Entities;
using Deadline6SecondTry.Models;

namespace Deadline6SecondTry
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {

        }

        public void StudentToStudentModels()
        {
            CreateMap<Student, StudentViewModel>()
                .ForMember(target => target.DepartmentName,
                    src => src.MapFrom(source => source.Group.Cafedre.Department.DepartmentName))
                .ForMember(target => target.GroupName, src => src.MapFrom(source => source.Group.GroupName))
                .ForMember(target => target.ProfileCafedreName,
                    src => src.MapFrom(source => source.Group.Cafedre.CafedreName)).ForMember(target => target.Name,
                    src => src.MapFrom(source =>
                        (source.Human.LastName + " " + source.Human.FirstName + " " + source.Human.MiddleName)));
        }
    }
}
