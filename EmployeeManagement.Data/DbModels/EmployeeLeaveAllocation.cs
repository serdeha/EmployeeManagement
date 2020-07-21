using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagement.Data.DbModels
{
    public class EmployeeLeaveAllocation:BaseEntity
    {
        public int NumberOfDays { get; set; }
        public DateTime DateCreated { get; set; }
        public int Period { get; set; }


        // İlişki kurmak için
        public string EmployeeID { get; set; }

        // hangi tablo ile ilişki kurmak istediğini parantez içerisine yazıyoruz. // oluşturduğumuz propertiyleri database taraafına aktarırken bazı kısıtlamalar ekleyebiliriz.
        [ForeignKey("EmployeeID")] 
        public Employee Employee { get; set; }


        public int EmployeeLeaveTypeID { get; set; }
        [ForeignKey("EmployeeLeaveTypeID")]
        public EmployeeLeaveType EmployeeLeaveType { get; set; }
    }
}
