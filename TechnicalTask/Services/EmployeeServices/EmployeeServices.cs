using TechnicalTask.Data.Models;
using TechnicalTask.Dtos.EmployeeDtos;
using TechnicalTask.Interfaces;

namespace TechnicalTask.Services.EmployeeServices
{
    public class EmployeeServices : AbstractionBaseServices, IEmployeeServices
    {
        protected readonly IUnitOfWork _UnitWork;

        public EmployeeServices(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
           _UnitWork = unitOfWork;
        }

        public async Task<Employee> AddEmployee(Employee employee)
        {
            try
            {
                var EmployeeExist = UnitWork.EmployeeRepos.Exists(x => x.Id == employee.Id).Result;
                if (EmployeeExist is not null)
                {
                    throw new Exception("The Employee Already Exists");
                }
           
              await UnitWork.EmployeeRepos.AddAsync(employee);
                await UnitWork.CommitAsync();
                return employee;

            }
            catch (Exception e)
            {

                throw new Exception("Error In Adding Employee");
            }
        }

        public async Task<IEnumerable<Employee>> GetAllActiveEmployees()
        {
            return await UnitWork.EmployeeRepos.GetAllActiveEmployees();
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await UnitWork.EmployeeRepos.GetAllEmployees();
        }

        public async Task<IEnumerable<Employee>> GetAllFemaleEmployees()
        {
            return await UnitWork.EmployeeRepos.GetAllFemaleEmployees();
        }

        public async Task<IEnumerable<Employee>> GetAllMaleEmployees()
        {
            return await UnitWork.EmployeeRepos.GetAllMaleEmployees();
        }

        public async Task<Employee> GetEmployeeById(int Id)
        {
            try
            {
                var Employee = await UnitWork.EmployeeRepos.GetAsync(Id);
                if (Employee is null)
                {
                    throw new Exception("The Employee With This Id Is Not Exist");

                }
                else
                {
                    return await UnitWork.EmployeeRepos.GetEmployeeById(Id);
                }
            }
            catch (Exception)
            {

                throw new Exception("Error Occured");
            }
        }
    }
}
