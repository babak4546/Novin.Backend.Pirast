using Novin.Pirast.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Pirast.Core.Entities.Customer
{
    public class Customer : Thing
    {
        public required string CustomerUsername { get; set; }
        public string? CustomerFirstname { get; set; }
        public string? CustomerLastname { get; set; }
        public required bool CustomerGender { get; set; }
        public string? CustomerNationalCode { get; set; }
        public DateTime CustomerBirthDate { get; set; }
        public required string CustomerPhoneNumber { get; set; }
        public string? CustomerAddress { get; set; }
        public bool CustomerVerified { get; set; } = false;
        public string? CustomerVerificationCode { get; set; }
        //public Payment CustomerPayment { get; set; }
        //Class Payment has not been created yet.
        public int CustomerPaymentId { get; set; }
        public string? CustomerDiscount { get; set; }
        public required List<Tiket> CustomerTicket { get; set; }
        public int CustomerTiketId { get; set; }
        public required List<Reservation> CustomerReservation { get; set; }
        public int CustomerReservationId { get; set; }
    }
}
