using AutoMapper;

namespace ProjectPatterns.Mapper
{
    public class EmployeeMapper
    {
        public void Map()
        {
            var config = new MapperConfiguration(config => config.CreateMap<Employee, EmployeeDTO>()
                .ForMember(x => x.Cat, act => act.MapFrom(
                    y => y.Dog)));

            var employee = new Employee
            {
                Name = "pru",
                Salary = 3000,
                Address = "jutro"
            };

            var mapper = new AutoMapper.Mapper(config);
            var employeeDTO = mapper.Map<EmployeeDTO>(employee);
        }
    }
}