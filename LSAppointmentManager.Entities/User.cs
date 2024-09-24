using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LSAppointmentManager.Entities
{
    [Table("ManagerUser")]
    public class User
    {
        [Key]
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public string? Lastname2 { get; set; }
        public string Email { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; }
    }
}
