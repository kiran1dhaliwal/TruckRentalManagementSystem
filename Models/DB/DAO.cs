using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalManagement.Models.DB
{
    class DAO
    {

        public List<TruckData> topFiveRentedTrucks()
        {
            using(var ctx = new GSQ2_Kiranjeet_DADContext())
            {
                List < TruckData> truck = ctx.TruckData.FromSql("topFiveRentedTrucks").ToList();
                return truck;
            }
        }

        public List<TruckData> leastFiveRentedTrucks()
        {
            using (var ctx = new GSQ2_Kiranjeet_DADContext())
            {
                List<TruckData> truck = ctx.TruckData.FromSql("leastFiveRentedTrucks").ToList();
                return truck;
            }
        }

        public int monthlysales(int month, int year)
        {
            using (var ctx = new GSQ2_Kiranjeet_DADContext())
            {
                int sales = int.Parse(ctx.MonthlySalesRecord.FromSql("rentSalesForSelectedMonth",month,year).FirstOrDefault().ToString());
                return sales;
            }
        }

        public int salesBetweenSelectedDates(DateTime startDate, DateTime endDate)
        {
            using (var ctx = new GSQ2_Kiranjeet_DADContext())
            {
                int sales = int.Parse(ctx.MonthlySalesRecord.FromSql("rentSalesBetweenGivenDates", startDate, endDate).FirstOrDefault().ToString());
                return sales;
            }
        }

    }
}
