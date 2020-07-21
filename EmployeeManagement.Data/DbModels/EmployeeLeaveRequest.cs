
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagement.Data.DbModels
{
    public class EmployeeLeaveRequest:BaseEntity
    {
        // TODO : Talepte kullanılan kullanıcı bilgileri
        public string RequestingEmployeeID { get; set; }
        [ForeignKey("RequestingEmployeeID")]
        public Employee RequestingEmployee { get; set; }

        // TODO : Onaylayan kullanılan kullanıcı bilgileri
        public string ApprovedEmployeeID { get; set; }
        [ForeignKey("ApprovedEmployeeID")]
        public Employee ApprovedEmployee { get; set; }


        public int EmployeeLeaveTypeID { get; set; }
        [ForeignKey("EmployeeLeaveTypeID")]
        public EmployeeLeaveType EmployeeLeaveType { get; set; }



        //-------------------------------------------------------------//

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DateRequested { get; set; }
        public string RequestComments { get; set; }
        public bool? Approved { get; set; }
        public bool Cancelled  { get; set; }
    }
}
