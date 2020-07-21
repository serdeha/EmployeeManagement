using EmployeeManagement.Data.DataContext;
using EmployeeManagement.Data.DbModels.Contracts;

namespace EmployeeManagement.Data.DbModels.Implemention
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EmployeeManagementContext _context;

        public UnitOfWork(EmployeeManagementContext context)
        {
            _context = context;
            employeeLeaveAllocation = new EmployeeLeaveAllocationRepository(_context);
            employeeLeaveRequest = new EmployeeLeaveRequestRepository(_context);
            employeeLeaveType = new EmployeeLeaveTypeRepository(_context);
        }

        public IEmployeeLeaveAllocationRepository employeeLeaveAllocation { get;private set; }
        public IEmployeeLeaveRequestRepository employeeLeaveRequest { get;private set; }
        public IEmployeeLeaveTypeRepository employeeLeaveType { get;private set; }



        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
