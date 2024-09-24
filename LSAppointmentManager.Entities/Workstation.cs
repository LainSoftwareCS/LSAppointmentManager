using LSAppointmentManager.Entities.Abstract;
using System.ComponentModel.DataAnnotations.Schema;
namespace LSAppointmentManager.Entities
{
    [Table("Workstation")]
    public class Workstation : AuditableEntity
    {
        public string Name { get; set; }
    }
}
