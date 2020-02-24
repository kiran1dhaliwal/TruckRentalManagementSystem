using System;
using System.Collections.Generic;

namespace RentalManagement.Models.DB
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string OfficeAddress { get; set; }
        public string PhoneExtension { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public virtual Person EmployeeNavigation { get; set; }
    }
}
