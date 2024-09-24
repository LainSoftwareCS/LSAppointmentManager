using LSAppointmentManager.Application.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSAppointmentManager.Application.Models.ProductService
{
    internal class SaveProductServiceDto : ICreateEntityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sku { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; } = 0;
        public bool HasTaxes { get; set; } = false;
        public bool HasTaxesIncluded { get; set; } = false;
        public DateTime CreatedDate { get; set; }
    }
}
