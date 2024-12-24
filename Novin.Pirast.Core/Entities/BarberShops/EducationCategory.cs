using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Pirast.Core.Entities.BarberShops
{
    public class EducationCategory:Education
    {
        public string Title { get; set; } = string.Empty; // نام دسته‌بندی
        public ICollection<Education> Educations { get; set; } = new List<Education>(); // لیست آموزش‌ها
    }
}
