using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Pirast.Core.Entities.Common.Reporting
{
    public class Revenue
    {
        public required int BarberShopId { get; set; }
        public decimal DailyRevenue { get; set; }
        public decimal WeeklyRevenue { get; set; }
        public decimal MonthlyRevenue { get; set; }
        public decimal YearlyRevenue { get; set; }
    }
}
