using AutoMapper;
using Demo.DAL.Models;
using Demo.PL.ViewModels;

namespace Demo.PL.MappingProfiles
{
    public class DepartmentProfile : Profile
    {
        public DepartmentProfile()
        {
            CreateMap<DepartmentViewModel, Department>()
                .ForMember(D => D.Code, O => O.MapFrom(S => S.DeptCode))
                .ForMember(D => D.Name, O => O.MapFrom(S => S.DeptName)).ReverseMap();

        }
    }
}
