using LSAppointmentManager.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSAppointmentManager.Entities
{
    public class Sale : AuditableEntity
    {
        public int? CustomerId { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Discount { get; set; }
        public decimal Taxes { get; set; }
        public decimal? Total { get; set; }
    }
}
