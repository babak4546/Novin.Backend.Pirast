using Novin.Pirast.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Pirast.Core.Entities
{
    internal class Thing : IThing
    {
        public int Id { get ; set ; }
        public string Guid { get  ; set; }
        public DateTime CreationTime { get ; set ; }
        public DateTime LastModificationTime { get ; set; }
    }
}
