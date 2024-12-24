using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Pirast.Core.Entities.Common.Reporting
{
    public class CustomersCount
    {
        public required int BarberShopId { get; set; }
        public int DailyCustomers { get; set; }
        public int WeeklyCustomers { get; set; }
        public int MonthlyCustomers { get; set; }
        public int YearlyCustomers { get; set; }

    }
}
