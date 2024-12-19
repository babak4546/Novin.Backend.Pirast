using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Backend.Pirast.Customer.Entities
{
    public class Customer
    {
        public required int Id { get; set; }
        public required string Guid { get; set; } = System.Guid.NewGuid().ToString();
        public required DateTime CreationTime { get; set; }
        public DateTime? LastModifiedTime { get; set; }
        public required string CustomerUsername { get; set; }
        public string? CustomerFirstname { get; set; }
        public string? CustomerLastname { get; set; }
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
        //public Ticket CustomerTicket { get; set; }
        //Class Ticket has not been created yet.
        public int CustomerTicketId { get; set; }
        //public Reservation CustomerReservation { get; set; }
        //Class Reservation has not been created yet.
        public int CustomerReservationId { get; set; }
    }
}
