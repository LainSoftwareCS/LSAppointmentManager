using LSAppointmentManager.Entities.Abstract;

namespace LSAppointmentManager.Entities
{
    public class Appointment : AuditableEntity
    {
        public Guid Guid { get; set; }
        public int CustomerId { get; set; }
        public int? WorkerId { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public bool IsCompleted { get; set; } = false;
        public bool IsConfirmed { get; set; } = false;
        public bool IsCancelled { get; set; } = false;
        public string Description { get; set; } = string.Empty;

    }
}
