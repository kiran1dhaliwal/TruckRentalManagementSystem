using System;
using System.Collections.Generic;

namespace RentalManagement.Models.DB
{
    public partial class Car
    {
        public Car()
        {
            CarFeatures = new HashSet<CarFeatures>();
            CarSaleRecord = new HashSet<CarSaleRecord>();
        }

        public int CarId { get; set; }
        public string Colour { get; set; }
        public string CurrentMileage { get; set; }
        public DateTime DateImported { get; set; }
        public string Transmission { get; set; }
        public int ManufacturerYear { get; set; }
        public string Status { get; set; }
        public string BodyType { get; set; }
        public int? CarModelId { get; set; }

        public virtual CarModel CarModel { get; set; }
        public virtual ICollection<CarFeatures> CarFeatures { get; set; }
        public virtual ICollection<CarSaleRecord> CarSaleRecord { get; set; }
    }
}
