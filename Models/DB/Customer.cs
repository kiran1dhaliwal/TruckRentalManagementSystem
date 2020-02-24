using System;
using System.Collections.Generic;

namespace RentalManagement.Models.DB
{
    public partial class Customer
    {
        public Customer()
        {
            CarSaleRecord = new HashSet<CarSaleRecord>();
        }

        public int CustomerId { get; set; }
        public string LicenceNumber { get; set; }
        public int Age { get; set; }
        public DateTime LicenceExpiryDate { get; set; }

        public virtual Person CustomerNavigation { get; set; }
        public virtual ICollection<CarSaleRecord> CarSaleRecord { get; set; }
    }
}
