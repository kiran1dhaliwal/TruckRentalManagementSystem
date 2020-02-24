using System;
using System.Collections.Generic;

namespace RentalManagement.Models.DB
{
    public partial class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
