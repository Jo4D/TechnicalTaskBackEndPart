using TechnicalTask.Data;
using TechnicalTask.Interfaces;
using TechnicalTask.Interfaces.IEmployeeRepositories;
using TechnicalTask.Repositories.EmployeeRepositories;

namespace TechnicalTask.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _Context;
        // private readonly IMapper _mapper;
        public UnitOfWork(ApplicationDbContext Context)
        {
            _Context = Context;
            EmployeeRepos = new EmployeeRepos(Context);
        }
        public IEmployeeRepos EmployeeRepos { get; }
        public async Task<int> CommitAsync()=>await _Context.SaveChangesAsync();
        public void Dispose() => _Context.Dispose();
    }
}