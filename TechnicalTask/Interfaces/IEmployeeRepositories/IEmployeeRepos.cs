using System.Linq.Expressions;
using TechnicalTask.Data.Models;
using TechnicalTask.Dtos.EmployeeDtos;

namespace TechnicalTask.Interfaces.IEmployeeRepositories
{
    public interface IEmployeeRepos:IRepository<Employee>
    {
        Task<Employee> GetEmployeeById(int id);
        Task<IEnumerable<Employee>> GetAllEmployees();
        Task<IEnumerable<Employee>> GetAllActiveEmployees();
        Task<IEnumerable<Employee>> GetAllMaleEmployees();
        Task<IEnumerable<Employee>> GetAllFemaleEmployees();


    }
}