using System.Linq.Expressions;
using TechnicalTask.Interfaces.IEmployeeRepositories;

namespace TechnicalTask.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> CommitAsync();
        IEmployeeRepos EmployeeRepos { get; }
    }
}
