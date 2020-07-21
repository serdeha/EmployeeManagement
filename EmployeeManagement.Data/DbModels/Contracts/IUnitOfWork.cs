using System;
using System.Collections.Generic;
using System.Text;

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
