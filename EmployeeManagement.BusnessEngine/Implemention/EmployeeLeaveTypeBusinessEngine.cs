using EmployeeManagement.BusnessEngine.Contracts;
using EmployeeManagement.Data.DbModels.Contracts;

namespace EmployeeManagement.BusnessEngine.Implemention
{
    public class EmployeeLeaveTypeBusinessEngine:IEmployeeLeaveTypeBusinessEngine
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeLeaveTypeBusinessEngine(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
