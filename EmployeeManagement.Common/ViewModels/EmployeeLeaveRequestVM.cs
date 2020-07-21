using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Common.ViewModels
{
    public class EmployeeLeaveRequestVM:BaseVM
    {

        public string RequestingEmployeeID { get; set; }
        public EmployeeVM RequestingEmployeeVm { get; set; }


        public string ApprovedEmployeeID { get; set; }
        public EmployeeVM ApprovedEmployeeVm { get; set; }


        public int EmployeeLeaveTypeID { get; set; }
        public EmployeeLeaveTypeVM EmployeeLeaveTypeVm { get; set; }


        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DateRequested { get; set; }

        [Display(Name = "Talep Açıklama")]
        [MaxLength(300,ErrorMessage = "300 karakterden fazla değer girilemez.")]
        public string RequestComments { get; set; }
        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }
    }
}
