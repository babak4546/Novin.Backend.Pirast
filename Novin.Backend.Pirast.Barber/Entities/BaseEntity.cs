using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Pirast.BarberShop.Entities
{
    public class BaseEntity
    {
        public virtual int Id { get; set; }
        public DateTime CreationTime { get; set; }

        public BaseEntity()
        {
            CreationTime = DateTime.Now;
        }
    }
}
