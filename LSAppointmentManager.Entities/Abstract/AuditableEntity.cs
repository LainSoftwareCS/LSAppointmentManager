using System.ComponentModel.DataAnnotations;

namespace LSAppointmentManager.Entities.Abstract
{
    public abstract class AuditableEntity
    {
        [Key]
        public int Id { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
