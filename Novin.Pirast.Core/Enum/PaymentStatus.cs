using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Pirast.Core.Enum
{
    public enum PaymentStatus
    {
        Payment = 1,         // A receipt for a successful payment
        Refund = 2,          // A receipt for a refund
        Adjustment = 3,      // A receipt for an adjustment (e.g., discount or correction)
        NonPayment = 4,
        SuccessPayment = 5,
        FailedPayment = 6
    }
}
