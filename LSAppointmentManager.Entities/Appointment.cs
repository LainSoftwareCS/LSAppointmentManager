using LSAppointmentManager.Entities.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace LSAppointmentManager.Entities
{
    [Table("Appointment")]
    public class Appointment : AuditableEntity
    {
        public Guid Guid { get; set; }
        public int CustomerId { get; set; }
        public int? WorkerId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsCompleted { get; set; } = false;
        public bool IsConfirmed { get; set; } = false;
        public bool IsCancelled { get; set; } = false;
        public string Description { get; set; } = string.Empty;

    }
}
