using LSAppointmentManager.Application.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSAppointmentManager.Application.Models.Customer
{
    public class SaveCustomerDto : ICreateEntityDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public string? Lastname2 { get; set; }
        public string Email { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; }
        public int Gender { get; set; } = 0;
        public DateTime? Birthdate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
