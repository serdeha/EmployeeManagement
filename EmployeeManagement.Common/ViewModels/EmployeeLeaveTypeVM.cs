using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EmployeeManagement.Common.ViewModels
{
    public class EmployeeLeaveTypeVM:BaseVM
    {
        [Required]
        public string Name { get; set; }
        public int DefaultDays { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsActive { get; set; }



        // MVVM Create EmployeeType
        public void SetEmployeeType(string name)
        {
            Name = name;
        }
    }
}
