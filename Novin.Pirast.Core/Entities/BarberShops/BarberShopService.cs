using Novin.Pirast.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Pirast.Core.Entities.BarberShops
{
    public class BarberShopService : Thing
    {

        // نام سرویس (مثلاً کوتاهی مو، و غیره).
        public string Title { get; set; } = string.Empty;
        public string? Price { get; set; }
        public byte[]? Photo { get; set; }
        public string? PhotoType { get; set; }
        public string? Description { get; set; }

        // کلید خارجی که سرویس را به دسته‌بندی آن متصل می‌کند.
        public int CategoryId { get; set; }

        // نشان می‌دهد که آیا سرویس مجاز  یا خیر.
        public bool AuthorizationStatus { get; set; } = true;

        // ویژگی ناوبری برای دسترسی به دسته‌بندی مرتبط.
        public BarberShop Category { get; set; }=new BarberShop();


        // نوع سرویس که به دسته‌بندی خاصی اشاره دارد.
        public ServiceType Type { get; set; }

        // نشان می‌دهد که آیا سرویس مجاز است یا خیر.
        public bool IsAllowed { get; set; } = true;
        public enum ServiceType
        {
            Hair,
            Body,
            Nails,
            Face,
        }
    }
}
