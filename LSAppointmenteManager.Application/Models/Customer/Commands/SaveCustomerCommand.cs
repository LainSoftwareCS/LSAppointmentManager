using Valibute.Attributes;

namespace LSAppointmentManager.Application.Models.Customer.Commands
{
    public class SaveCustomerCommand 
    {
        [VNotEmpty("name", ErrorMessage = "El nombre no puede estar vacio")]
        public string Name { get; set; } = string.Empty;

        [VNotEmpty("lastname", ErrorMessage = "El apellido paterno no puede estar vacio")]
        public string Lastname { get; set; } = string.Empty;
        public string? Lastname2 { get; set; }
        [VEmail("email", ErrorMessage = "Favor de validar el formato del e-mail")]
        public string Email { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; }
        public int Gender { get; set; } = 0;
        public DateTime? Birthdate { get; set; }
    }
}
