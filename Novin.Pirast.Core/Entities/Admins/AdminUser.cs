using Novin.Pirast.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Pirast.Core.Entities.Admins
{
    public class AdminUser : Thing
    {
        public string AdminName { get; set; }
        public string AdminPassword { get; set; }
        public int NewCustomer { get; set; }
        public int ActiveCustomer { get; set; }
        public int GrowthRate { get; set; }
        public int IncomeReport { get; set; }
        public List<int> PirastUserId { get; set; }
        public List<Ticket> Tickets { get; set; }
        public List<Comments> Comments { get; set; }
    }
}
