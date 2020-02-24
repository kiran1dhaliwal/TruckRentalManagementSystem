using System;
using System.Collections.Generic;

namespace RentalManagement.Models.DB
{
    public partial class TruckEmployee
    {
        public int EmployeeId { get; set; }
        public string OfficeAddress { get; set; }
        public string PhoneExtensionNumber { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public virtual TruckPerson Employee { get; set; }
    }
}
