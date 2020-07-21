using EmployeeManagement.Data.DbModels.Contracts;
using System;
using System.Linq;
using System.Linq.Expressions;
using EmployeeManagement.Data.DataContext;

namespace EmployeeManagement.Data.DbModels.Implemention
{
    public class EmployeeLeaveAllocationRepository:Repository<EmployeeLeaveAllocation>,IEmployeeLeaveAllocationRepository
    {
        private readonly EmployeeManagementContext _context;

        public EmployeeLeaveAllocationRepository(EmployeeManagementContext context):base(context)
        {
            _context = context;
        }
    }
}
