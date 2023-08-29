using Microsoft.EntityFrameworkCore;
using TechnicalTask.Data;
using TechnicalTask.Data.Models;
using TechnicalTask.Interfaces.IEmployeeRepositories;

namespace TechnicalTask.Repositories.EmployeeRepositories
{
    public class EmployeeRepos : Repository<Employee>, IEmployeeRepos
    {
        public EmployeeRepos(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Employee>> GetAllActiveEmployees()
        {
            return await Context.Employees.Where(x=>x.IsActive).AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {

            return   await Context.Employees.AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<Employee>> GetAllFemaleEmployees()
        {
            return await Context.Employees.Where(x=>x.Gender.ToLower()=="female").AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<Employee>> GetAllMaleEmployees()
        {
            return await Context.Employees.Where(x => x.Gender.ToLower() == "male").AsNoTracking().ToListAsync();
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
         return  await Context.Employees.Where(x => x.Id == id).FirstOrDefaultAsync();

        }


    }
}
