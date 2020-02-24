using System;
using System.Collections.Generic;

namespace RentalManagement.Models.DB
{
    public partial class CarFeatures
    {
        public int CarId { get; set; }
        public int CarFeatureId { get; set; }

        public virtual Car Car { get; set; }
        public virtual CarFeature CarFeature { get; set; }
    }
}
