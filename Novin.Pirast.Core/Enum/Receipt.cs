using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Pirast.Core.Enum
{
    public enum Receipt
    {
      Pending = 1,         // Receipt is generated but not yet finalized
      Issued = 2,          // Receipt has been issued to the customer
      Canceled = 3,        // Receipt was generated but later canceled
      Reissued = 4         // Receipt has been reissued
    }
}
