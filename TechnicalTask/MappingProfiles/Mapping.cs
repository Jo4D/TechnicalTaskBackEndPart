using AutoMapper;
using TechnicalTask.Data.Models;
using TechnicalTask.Dtos.EmployeeDtos;

namespace TechnicalTask.MappingProfiles
{
    public class Mapping:Profile
    {
        public Mapping()
        {
            CreateMap<AddEmployeeDto,Employee>().ReverseMap();
            CreateMap<GetEmployeeDto, Employee>().ReverseMap();

        }
    }
}
