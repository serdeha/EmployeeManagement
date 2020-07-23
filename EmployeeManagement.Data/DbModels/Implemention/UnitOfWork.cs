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
            employeeLeaveAllocationRepository = new EmployeeLeaveAllocationRepository(_context);
            employeeLeaveTypeRepository = new EmployeeLeaveTypeRepository(_context);
            employeeLeaveRequestRepository = new EmployeeLeaveRequestRepository(_context);
        }

        public IEmployeeLeaveAllocationRepository employeeLeaveAllocationRepository { get; private set; }
        public IEmployeeLeaveTypeRepository employeeLeaveTypeRepository { get; private set; }
        public IEmployeeLeaveRequestRepository employeeLeaveRequestRepository { get; private set; }

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
