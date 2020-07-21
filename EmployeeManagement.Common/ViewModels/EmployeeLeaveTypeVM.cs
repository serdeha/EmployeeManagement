using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Common.ViewModels
{
    public class EmployeeLeaveTypeVM:BaseVM
    {
        [Required]
        public string Name { get;protected set; }
        public int DefaultDays { get;protected set; }
        public DateTime DateCreated { get;protected set; }



        // MVVM Create EmployeeType
        public void SetEmployeeType(string name)
        {
            Name = name;
        }
    }
}
