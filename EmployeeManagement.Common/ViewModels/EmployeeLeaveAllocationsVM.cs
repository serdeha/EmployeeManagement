using System;

namespace EmployeeManagement.Common.ViewModels
{
    public class EmployeeLeaveAllocationsVM:BaseVM
    {
        public int NumberOfDays { get; set; }
        public DateTime DateCreated { get; set; }
        public int Period { get; set; }


        
        public string EmployeeID { get; set; }
        public EmployeeVM EmployeeVm { get; set; }


        public int EmployeeLeaveTypeID { get; set; }
        public EmployeeLeaveTypeVM EmployeeLeaveTypeVm { get; set; }
    }
}
