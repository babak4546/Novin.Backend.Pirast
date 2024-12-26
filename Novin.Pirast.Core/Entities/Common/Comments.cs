using Novin.Pirast.Core.Entities.BarberShops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Pirast.Core.Entities.Common
{
    public class Comments
    {
        public int Id { get; set; }
        public required PirastUser PirastUser { get; set; }
        public required string PirastUserPhoneNumber { get; set; }
        public required BarberShop BarberShop { get; set; }
        public int BarberShopId { get; set; }
        public bool IsAccepted { get; set; } = false;
        public required string Description { get; set; }
    }
}
