using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Data.DbModels
{
    public class BaseEntity
    {
        [Key]
        public int ID { get; set; }
    }
}
