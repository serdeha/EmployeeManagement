using EmployeeManagement.Data.DataContext;
using EmployeeManagement.Data.DbModels.Contracts;

namespace EmployeeManagement.Data.DbModels.Implemention
{
    public class EmployeeLeaveRequestRepository:Repository<EmployeeLeaveRequest>,IEmployeeLeaveRequestRepository
    {
        private readonly EmployeeManagementContext _context;
        public EmployeeLeaveRequestRepository(EmployeeManagementContext context) : base(context)
        {
            _context = context;
        }
    }
}
