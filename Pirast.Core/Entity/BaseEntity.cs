using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirast.Core.Entity
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string? Guid { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
