using System;

namespace EmployeeManagement.Data.DbModels.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        IEmployeeLeaveAllocationRepository employeeLeaveAllocationRepository { get; }
        IEmployeeLeaveTypeRepository employeeLeaveTypeRepository { get; }
        IEmployeeLeaveRequestRepository employeeLeaveRequestRepository { get; }
        void Save();
    }
}
