using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalManagement.Models.DB
{
    public class MonthlySalesRecord
    {
        public int saleID { get; set; }
        public int month { get; set; }
        public int year { get; set; }
        public float salesAmount { get; set; }
    }
}
