using Novin.Pirast.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Pirast.Core.Entities.Transactions
{
    public class Payment:IThing
    {
    public Guid Id { get; set; } //primary key
    public decimal Price { get; set; }
    public decimal Amount { get; set; }
    public string PaymentMethod { get; set; }//credit card, cash,....
    public string PaymentStatus { get; set; }//success.failed
    public string TransactionId { get; set; }
    public string TransactionType { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public int ReservationId { get; set; }//Foreign key
    public Reservation Reservation { get; set; }//Navigation
    public int PirastUserId { get; set; }//Foreign key
    public PirastUser PirastUser { get; set; }//Navigation

}
}
