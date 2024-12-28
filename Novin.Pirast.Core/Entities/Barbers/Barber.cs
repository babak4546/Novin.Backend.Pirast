using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Novin.Pirast.Core.Entities.BarberShops;
using Novin.Pirast.Core.Entities.Common;

namespace Novin.Pirast.Core.Entities.Barbers
{
    public class Barber : Thing
    {
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? BarberPassword { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        //public bool Gender { get; set; }
        public byte[]? Photo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? WorkAddress { get; set; }
        public string? ResidentialAddress { get; set; }
        public List<string>? SocialMedia { get; set; }
        public string? Policy { get; set; }
        public List<byte[]>? Certificate { get; set; }

        
        public List<BarberShop>? BarberShops { get; set; }
        public List<BarberShopService>? BarberShopServices { get; set; }
        //public List<Reporting> Reportings { get; set; }           //خطا داره مثل این که آماده نیست
        public List<Ticket>? Tickets { get; set; }
        public List<Comments>? Comments { get; set; }
        public List<Reservation>? Reservations { get; set; }
    }
}
