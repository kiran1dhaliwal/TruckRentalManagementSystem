using System;
using System.Collections.Generic;

namespace RentalManagement.Models.DB
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public int StockMaxLimit { get; set; }
        public int StockMinLimit { get; set; }
        public bool Available { get; set; }
    }
}
