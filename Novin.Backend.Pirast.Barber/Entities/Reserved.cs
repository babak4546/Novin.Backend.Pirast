using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Pirast.BarberShop.Entities
{
    public class Reserved : BaseEntity
    {
        //public Customer Customer { get; set; }
        public List<BarberService>? BarberServices { get; set; }
        //public string CustomerPhone { get; set; }
        public DateTime Date { get; set; }
        public string? Message { get; set; }
        public bool? IsReserved { get; set; } = false;
    }
}
