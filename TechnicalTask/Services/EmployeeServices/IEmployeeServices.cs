using TechnicalTask.Data.Models;
using TechnicalTask.Dtos.EmployeeDtos;

namespace TechnicalTask.Services.EmployeeServices
{
    public interface IEmployeeServices
    {
        Task<Employee> GetEmployeeById(int id);
        Task<IEnumerable<Employee>> GetAllEmployees();
        Task<Employee> AddEmployee(Employee employee);
        Task<IEnumerable<Employee>> GetAllActiveEmployees();
        Task<IEnumerable<Employee>> GetAllMaleEmployees();
        Task<IEnumerable<Employee>> GetAllFemaleEmployees();
    }
}