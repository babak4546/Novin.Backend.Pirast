using Novin.Pirast.Core.Entities.Common;
using Novin.Pirast.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Pirast.Core.Entities.Transactions
{
    public class Receipts : IThing, PirastUser
    {
        public Guid Id { get; set; } // Primary Key

        public int ReservationId { get; set; } // Foreign Key for the related appointment
        public Reservation Reservation { get; set; } // Navigation property

        public DateTime IssuedDate { get; set; } // Date the receipt was issued

        public decimal TotalAmount { get; set; } // Total amount paid
        public string PaymentMethod { get; set; } // Payment method (e.g., Cash, Credit Card, etc.)

        public string ReceiptNumber { get; set; } // Unique identifier for the receipt

        public string Notes { get; set; } // Additional notes (optional)

    }
}
