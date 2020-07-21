using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Common.ViewModels
{
    public class BaseVM
    {
        [Key]
        public int ID { get; set; }
    }
}
