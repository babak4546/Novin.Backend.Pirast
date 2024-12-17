using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Pirast.Core.Entity
{
    public class Admins:ApplicationUser
    {
        public string Role { get; set; }
        public List<Ticket> Tickets { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Report> Reports { get; set; }
        public List<Users> Users { get; set; }
        public List<Barbershop> Barbershops { get; set; }
    }
}
