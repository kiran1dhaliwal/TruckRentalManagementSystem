using System;
using System.Collections.Generic;

namespace RentalManagement.Models.DB
{
    public partial class IndividualTruck
    {
        public IndividualTruck()
        {
            TruckFeatureAssociation = new HashSet<TruckFeatureAssociation>();
            TruckRental = new HashSet<TruckRental>();
        }

        public int TruckId { get; set; }
        public string Colour { get; set; }
        public string RegistrationNumber { get; set; }
        public DateTime WofexpiryDate { get; set; }
        public DateTime RegistrationExpiryDate { get; set; }
        public DateTime DateImported { get; set; }
        public int ManufactureYear { get; set; }
        public string Status { get; set; }
        public string FuelType { get; set; }
        public string Transmission { get; set; }
        public decimal DailyRentalPrice { get; set; }
        public decimal AdvanceDepositRequired { get; set; }
        public int TruckModelId { get; set; }

        public virtual TruckModel TruckModel { get; set; }
        public virtual ICollection<TruckFeatureAssociation> TruckFeatureAssociation { get; set; }
        public virtual ICollection<TruckRental> TruckRental { get; set; }
    }
}
