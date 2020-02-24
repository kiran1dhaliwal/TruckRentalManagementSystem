using System;
using System.Collections.Generic;

namespace RentalManagement.Models.DB
{
    public partial class CustomerT
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
