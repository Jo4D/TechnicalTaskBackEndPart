using TechnicalTask.Interfaces;

namespace TechnicalTask.Services
{
    public class AbstractionBaseServices
    {
        protected readonly IUnitOfWork UnitWork;
       // protected readonly IMapper Map;
        public AbstractionBaseServices(IUnitOfWork unitOfWork)
        {
            UnitWork = unitOfWork;
            //Map = mapper;
        }
    }
}
