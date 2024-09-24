using LSAppointmentManager.Application.Contracts.Models;

namespace LSAppointmentManager.Application.Models.Workstations
{
    public class SaveWorkstationDto : ICreateEntityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
