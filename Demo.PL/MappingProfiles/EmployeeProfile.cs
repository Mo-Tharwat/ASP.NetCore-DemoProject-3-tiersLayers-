using AutoMapper;
using Demo.DAL.Models;
using Demo.PL.ViewModels;

namespace Demo.PL.MappingProfiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<EmployeeViewModel, Employee>()
                .ForMember(D => D.Name, O => O.MapFrom(S => S.EmpName))
                .ForMember(D => D.Age, O => O.MapFrom(S => S.EmpAge))
                .ForMember(D => D.Address, O => O.MapFrom(S => S.EmpAddress))
                .ForMember(D => D.Salary, O => O.MapFrom(S => S.EmpSalary))
                .ForMember(D => D.IsActive, O => O.MapFrom(S => S.EmpIsActive))
                .ForMember(D => D.Email, O => O.MapFrom(S => S.EmpEmail))
                .ForMember(D => D.Phone, O => O.MapFrom(S => S.EmpPhone))
                .ForMember(D => D.HireDate, O => O.MapFrom(S => S.EmpHireDate)).ReverseMap();
        }
    }
}
