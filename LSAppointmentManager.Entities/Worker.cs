using LSAppointmentManager.Entities.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace LSAppointmentManager.Entities
{
    [Table("Worker")]
    public class Worker : AuditableEntity
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string? Lastname2 { get; set; }
        public DateTime? Birthdate { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public Int16 Gender { get; set; } 
        public int WorkstationId { get; set; }
    }
}
