using LSAppointmentManager.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSAppointmentManager.Entities
{
    public class ProductService : AuditableEntity
    {
        public string Name { get; set; }
        public string Sku { get; set; }
        public string Codebar { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool HasTaxes { get; set; }
        public bool HasTaxesIncluded { get; set; }

    }
}
