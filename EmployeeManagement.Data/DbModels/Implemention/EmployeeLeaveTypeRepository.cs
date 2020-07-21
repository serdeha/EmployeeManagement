

using EmployeeManagement.Data.DataContext;
using EmployeeManagement.Data.DbModels.Contracts;

namespace EmployeeManagement.Data.DbModels.Implemention
{
    public class EmployeeLeaveTypeRepository:Repository<EmployeeLeaveType>,IEmployeeLeaveTypeRepository
    {
        private readonly EmployeeManagementContext _context;
        public EmployeeLeaveTypeRepository(EmployeeManagementContext context) : base(context)
        {
            _context = context;
        }
    }
}
