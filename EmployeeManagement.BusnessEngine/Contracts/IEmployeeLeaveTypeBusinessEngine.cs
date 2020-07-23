using System.Collections.Generic;
using EmployeeManagement.BusnessEngine.ResultModels;
using EmployeeManagement.Common.ViewModels;
using EmployeeManagement.Data.DbModels;

namespace EmployeeManagement.BusnessEngine.Contracts
{
    public interface IEmployeeLeaveTypeBusinessEngine
    {
        Result<List<EmployeeLeaveTypeVM>> GetAllEmployeeLeaveTypes();

        /// <summary>
        /// New Employee Leave Type Create Method
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Result<EmployeeLeaveTypeVM> CreateEmployeeLeaveType(EmployeeLeaveTypeVM model);

        /// <summary>
        /// Get Employee Leave Type By ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Result<EmployeeLeaveTypeVM> GetAllEmployeeLeaveType(int id);

        Result<EmployeeLeaveTypeVM> EditEmployeeLeaveType(EmployeeLeaveTypeVM model);

        Result<EmployeeLeaveTypeVM> RemoveEmployeeLeaveType(int id);
    }
}
