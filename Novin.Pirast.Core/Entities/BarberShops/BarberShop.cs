using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Novin.Pirast.Core.Entities.BarberShops.BarberShopService;

namespace Novin.Pirast.Core.Entities.BarberShops
{
    public class BarberShop:BarberShopService
    {
        //این بخش برای نام اریشگاه - نام مسئول-آدرس- شماره تماس هستش
        #region
        public  string TitleBarberShop { get; set; }
        public  string OwnerFirstname { get; set; }
        public  string OwnerLastname { get; set; }
        public  string Address { get; set; }
        [Phone]
        public PhoneAttribute? ContactNumber { get; set; }
        public string? Email { get; set; }
        public string? Gender { get; set; }
        public string Password { get; set; }
        public byte[] Photo { get; set; }
        public DateTime Dateofbirth { get; set; }
        public string Nationalcode { get; set; }
        public string CertificateList { get; set; }

        #endregion

        //این برای بخش های مشترک است
        #region 
        //public <NormalUser> NormalUsers { get; set; }
        //public <Barber> Barbers { get; set; }
        //public < Tiket > Tikets { get; set; }
        //public < Reporting > Reportings { get; set; }
        //public < Comments > Comments { get; set; }
        //public < Reservation > Reservations { get; set; }
        #endregion




// مجموعه‌ای از سرویس‌هایی که به این دسته‌بندی تعلق دارند.
//ICollection از پیش در dotnet تعریف شده که برای (Add-Remove-Contains-Count- Clear)
public ICollection<BarberShopService> Services { get; set; } = new List<BarberShopService>();

    }
}
