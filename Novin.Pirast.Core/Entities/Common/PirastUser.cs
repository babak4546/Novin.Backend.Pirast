using Novin.Pirast.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Pirast.Core.Entities.Common
{
    public class PirastUser : Thing
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string PassWord { get; set; } // این همون شماره تلفنه
        public string? NationalCode { get; set; }
        public List<Ticket>? Tickets { get; set; }
        public List<Reservation>? Reserves { get; set; }
        public required PirastUserType Type { get; set; }
        public required string Wallet { get; set; }
        public string UserType
        {
            get
            {
                switch (this.Type)
                {
                    case PirastUserType.SystemAdmin:
                        return "مدیریت سیستم";
                        break;
                    case PirastUserType.Costomer:
                        return "مشتری";
                        break;
                    case PirastUserType.BarberShopOwner:
                        return "آرایشگاه دار";
                        break;
                    default:
                        break;
                }
                return "ناشناخته";
            }
        }
    }
}
