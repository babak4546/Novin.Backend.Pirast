using Novin.Pirast.Barber.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Pirast.Barber.Entities
{
    public class BarberRequest
    {
        //به ادمین یا پشتیبانی ارسال میشود
        public BarberRequestType Type { get; set; }
        public BarberRequestPriority Priority { get; set; }
        public string? RequestSubject { get; set; }
        public string? RequestText { get; set; }
        public string? ResponseRequest { get; set; }
        public string RequestType
        {
            get
            {
                switch (this.Type)
                {
                    case BarberRequestType.SystemProblem:
                        return "مشکل سیستمی";
                        break;
                    case BarberRequestType.TechnicalProblem:
                        return "مشکل فنی";
                        break;
                    default:
                        break;
                }
                return "ناشناس";
            }
        }
        public string RequestPriority
        {
            get
            {
                switch (this.Priority)
                {
                    case BarberRequestPriority.VeryHigh:
                        return "خیلی زیاد";
                        break;
                    case BarberRequestPriority.High:
                        return "زیاد";
                        break;
                    case BarberRequestPriority.Normal:
                        return "متوسط";
                        break;
                    case BarberRequestPriority.Low:
                        return "کم";
                        break;
                    case BarberRequestPriority.VeryLow:
                        return "خیلی کم";
                        break;
                    default:
                        break;
                }
                return "ناشناس";
            }
        }
    }
}
