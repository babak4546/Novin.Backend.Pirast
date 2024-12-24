using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Pirast.Core.Entities.BarberShops
{
    public class Education:Thing
    {
        public string Title { get; set; } = string.Empty; // عنوان آموزش
        public string Description { get; set; } = string.Empty; // توضیحات آموزش
        public string VideoUrl { get; set; } = string.Empty; // لینک ویدئو
        public string TextContent { get; set; } = string.Empty; // متن آموزش
        public int CategoryId { get; set; } // دسته‌بندی آموزش
        public required EducationCategory Category { get; set; } // دسته‌بندی مرتبط
    }
}
