namespace Novin.Backend.Pirast.Entities
{
    public class Customer
    {
        public required int Id { get; set; }
        public required string Guid { get; set; } = System.Guid.NewGuid().ToString();
        public required DateTime CreationTime { get; set; }
        public DateTime? LastModifiedTime { get; set; }
        public string Username { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? NationalCode { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string? Address { get; set; }
        public bool Verified { get; set; } = false;
        public string VerificationCode { get; set; }
        public Payment PirastPayment { get; set; }
        public int PirastPaymentId { get; set; }
        public string? Discount { get; set; }
        public Ticket PirastTicket { get; set; }
        public int PirastTicketId { get; set; }
        public Reservation PirastReservation { get; set; }
        public int PirastReservationId { get; set; }
    }
}
