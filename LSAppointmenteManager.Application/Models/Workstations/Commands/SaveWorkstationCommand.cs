using Valibute.Attributes;

namespace LSAppointmentManager.Application.Models.Workstations.Commands
{
    public class SaveWorkstationCommand
    {
        [VNotEmpty("name", ErrorMessage = "El nombre no puede estar vacio")]
        public string Name { get; set; }
    }
}
