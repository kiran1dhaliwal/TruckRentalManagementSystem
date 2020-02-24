using System;
using System.Collections.Generic;

namespace RentalManagement.Models.DB
{
    public partial class CarSaleRecord
    {
        public int SaleRecordId { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public DateTime PuchaseDate { get; set; }
        public decimal TotalPaidPrice { get; set; }
        public string Note { get; set; }

        public virtual Car Car { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
