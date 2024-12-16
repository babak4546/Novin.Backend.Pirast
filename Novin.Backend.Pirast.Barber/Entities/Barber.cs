using Novin.Pirast.BarberShop.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Pirast.BarberShop.Entities
{
    public class Barber : BaseEntity
    {
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public bool Verified { get; set; } = false;
        public string? VerificationCode { get; set; }
        //public bool Gender { get; set; }
        public byte[]? Photo { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? NationalCode { get; set; }
        public string? WorkAddress { get; set; }
        public string? ResidentialAddress { get; set; }
        public DateTime WorkPlan { get; set; }
        public List<string>? SocialMedia { get; set; }
        public string? Policy { get; set; }
        public List<byte[]>? Document { get; set; }
        public List<BarberService>? Sevices { get; set; }

    }
}
