using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Pirast.Core.Interfaces
{
    public interface IThing
    {
        int Id { get; set; }
        string Guid { get; set; }
        DateTime CreationTime { get; set; }
        DateTime LastModificationTime { get; set; }
    }
}
