using Novin.Pirast.BarberShop.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Pirast.BarberShop.Entities
{
    public class BarberService : BaseEntity
    {
        public string? Title { get; set; }
        public string? Price { get; set; }
        public byte[]? Photo { get; set; }
        public string? PhotoType { get; set; }
        public string? Description { get; set; }
        public bool IsAvailable { get; set; }
        public int ServicePeriod { get; set; }//مدت زمان انجام کار
        public int Rate { get; set; }
        public bool IsActive { get; set; } = false;
        public BarberServiceType Type { get; set; }
        public string ServiceType
        {
            get
            {
                switch (this.Type)
                {
                    case Enums.BarberServiceType.Hair:
                        return "مو";
                        break;
                    case Enums.BarberServiceType.Skin:
                        return "پوست";
                        break;
                    case Enums.BarberServiceType.Face:
                        return "صورت";
                        break;
                    case Enums.BarberServiceType.Body:
                        return "بدن";
                        break;
                }
                return "ناشناس";
            }
        }
    }
}
