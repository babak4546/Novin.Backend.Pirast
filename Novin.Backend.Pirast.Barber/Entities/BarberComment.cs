using Novin.Pirast.BarberShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Pirast.Barber.Entities
{
    public class BarberComment
    {
        //نمیدونم چطوری اسم کاربری که نظر داده رو اضافه کنم اینجا
        public DateTime Date { get; set; }
        public BarberService? BarberService { get; set; }
        public string? CommentPreview { get; set; }
        public string? Category { get; set; }
    }
}
