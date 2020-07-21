using System;
using Microsoft.AspNetCore.Identity;

namespace EmployeeManagement.Data.DbModels
{
    public class Employee:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TaxID { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
