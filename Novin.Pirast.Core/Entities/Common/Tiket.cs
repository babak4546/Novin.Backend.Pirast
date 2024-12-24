using Novin.Pirast.Core.Entities.BarberShops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Pirast.Core.Entities.Common
{
    public class Tiket : Thing
    {
        public required PirastUser PirastUser { get; set; }
        public required string PirastUserPhoneNumber { get; set; }
        public required BarberShop BarberShop { get; set; }
        public int BarberShopId { get; set; }
        public required string Title { get; set; }
        public required string RequestPriority { get; set; }
        public required string RequestType { get; set; }
        public required string Description { get; set; }
        public bool IsClosed { get; set; } = false;

    }
}
