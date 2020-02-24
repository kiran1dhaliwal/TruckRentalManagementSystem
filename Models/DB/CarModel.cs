using System;
using System.Collections.Generic;

namespace RentalManagement.Models.DB
{
    public partial class CarModel
    {
        public CarModel()
        {
            Car = new HashSet<Car>();
        }

        public int ModelId { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Seats { get; set; }
        public string EngineSize { get; set; }

        public virtual ICollection<Car> Car { get; set; }
    }
}
