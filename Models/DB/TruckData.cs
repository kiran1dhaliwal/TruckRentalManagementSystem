using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalManagement.Models.DB
{
    public class TruckData
    {
        public int TruckId { get; set; }
        public string model { get; set; }
        public string manufacturer { get; set; }
        public string colour { get; set; } 
        public string registrationNumber { get; set; } 
        public decimal DailyRentalPrice { get; set; }
    }
}
