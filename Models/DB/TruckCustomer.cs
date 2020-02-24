using System;
using System.Collections.Generic;

namespace RentalManagement.Models.DB
{
    public partial class TruckCustomer
    {
        public TruckCustomer()
        {
            TruckRental = new HashSet<TruckRental>();
        }

        public int CustomerId { get; set; }
        public string LicenseNumber { get; set; }
        public int Age { get; set; }
        public DateTime LicenseExpiryDate { get; set; }

        public virtual TruckPerson Customer { get; set; }
        public virtual ICollection<TruckRental> TruckRental { get; set; }
    }
}
