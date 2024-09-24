using LSAppointmentManager.Application.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valibute.Attributes;

namespace LSAppointmentManager.Application.Models.ProductService.Commands
{
    public class UpdateProductServiceCommand : IUpdateEntityCommand
    {
        public int Id { get; set; }
        [VNotEmpty("name", ErrorMessage = "El nombre no puede ir vacio")]
        public string Name { get; set; }
        [VNotEmpty("name", ErrorMessage = "El sku no puede ir vacio")]
        public string Sku { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; } = 0;
        public bool HasTaxes { get; set; } = false;
        public bool HasTaxesIncluded { get; set; } = false;
    }
}
