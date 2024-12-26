using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Pirast.Core.Entities.Common.Reporting
{
    public class CustomerSatisfaction
    {
        public required int BarberShopId { get; set; }
        public required List<int> Ratings { get; set; }
        public CustomerSatisfaction()
        {
            Ratings = new List<int>();
        }

    }
}
