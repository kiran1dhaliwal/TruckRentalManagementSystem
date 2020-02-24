using System;
using System.Collections.Generic;

namespace RentalManagement.Models.DB
{
    public partial class CarFeature
    {
        public CarFeature()
        {
            CarFeatures = new HashSet<CarFeatures>();
        }

        public int CarFeatureId { get; set; }
        public string Feature { get; set; }

        public virtual ICollection<CarFeatures> CarFeatures { get; set; }
    }
}
