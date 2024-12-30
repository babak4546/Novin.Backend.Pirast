using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Novin.Pirast.Core.Entities.Barbers;
using Novin.Pirast.Core.Entities.Common;
using Novin.Pirast.Core.Entities.Customer;
using Novin.Pirast.Core.Entities.Transactions;
using Novin.Pirast.Core.Enum;
using static Novin.Pirast.Core.Entities.BarberShops.BarberShopService;

namespace Novin.Pirast.Core.Entities.BarberShops
{
    public class BarberShop : BarberShopService
    {
        //این بخش برای نام اریشگاه - نام مسئول-آدرس- شماره تماس هستش
        #region
        public string? TitleBarberShop { get; set; }
        public string? OwnerFirstname { get; set; }
        public string? OwnerLastname { get; set; }
        public string? Address { get; set; }
        public string? ContactNumber { get; set; }
        public string? Email { get; set; }
        public string? Gender { get; set; }
        public string? Password { get; set; }
        public byte[] Photo { get; set; }
        public DateTime Dateofbirth { get; set; }
        public string? Nationalcode { get; set; }
        public string? CertificateList { get; set; }

        #endregion

        //این برای بخش های مشترک است
        #region 
        public List<NormalUser>? NormalUsers { get; set; }
        public int NormalUsersId { get; set; }
        public List<Barber>? Barber { get; set; }
        public int BarberId { get; set; }
        public List<Ticket>? Ticket { get; set; }
        public int TicketsId { get; set; }

        public List< Reporting > Reporting { get; set; }//parsa nazade ya eshtebah zade
        public int ReportingId { get; set; }
        public List< Comments >? Comment { get; set; }
        public int CommentId { get; set; }
        public List<Payment> Payment { get; set; }
        public int PaymentId { get; set; }
        public List<Receipt> Receipt { get; set; }
        public List< Reservation >? Reservation{ get; set; }
        public int ReservationId { get; set; }

        #endregion

    }
}
