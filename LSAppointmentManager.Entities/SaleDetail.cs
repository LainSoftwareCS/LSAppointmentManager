using LSAppointmentManager.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSAppointmentManager.Entities
{
    public class SaleDetail : AuditableEntity
    {
        public int SaleId { get; set; }
        public int ProductServiceId { get; set; }  
        public decimal Quantity { get; set; } 
        public decimal Price { get; set; } 
        public decimal Discount { get; set; } 
        public decimal Taxes { get; set; } 
        public decimal Subtotal { get; set; }
        public decimal Total { get; set; }

        public void CalculateTotal()
        {
            Total = Quantity * Price;
        }

    }

}
