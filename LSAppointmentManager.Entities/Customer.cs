using LSAppointmentManager.Entities.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace LSAppointmentManager.Entities
{
    [Table("Customer")]
    public class Customer : AuditableEntity
    {
        public string? Name { get; set; } 
        public string? Lastname { get; set; }
        public string? Lastname2 { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public int? Gender { get; set; }
        public DateTime? Birthdate { get; set; }
    }
}
