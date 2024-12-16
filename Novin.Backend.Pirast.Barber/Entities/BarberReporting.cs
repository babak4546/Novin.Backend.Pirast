using Novin.Pirast.Barber.Enums;
using Novin.Pirast.BarberShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Pirast.Barber.Entities
{
    public class BarberReporting : BaseEntity
    {
        //public List<Customer>? Customers { get; set; }
        public DateTime Date { get; set; }
        public BarberService? Service { get; set; }
        public Reserved? Reserved { get; set; }
        public int Expense { get; set; }
        public BarberExpenseType Type { get; set; }
        public string ExpenseType
        {
            get
            {
                switch (this.Type)
                {
                    case BarberExpenseType.Daily:
                        return "روزانه";
                        break;
                    case BarberExpenseType.Weekly:
                        return "هفتگی";
                        break;
                    case BarberExpenseType.Mounthly:
                        return "ماهانه";
                        break;
                    case BarberExpenseType.Yearly:
                        return "سالانه";
                        break;
                    default:
                        break;
                }
                return "ناشناس";
            }
        }
    }
}
