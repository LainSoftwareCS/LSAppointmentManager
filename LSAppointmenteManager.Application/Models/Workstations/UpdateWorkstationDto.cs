using LSAppointmentManager.Application.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSAppointmentManager.Application.Models.Workstations
{
    public class UpdateWorkstationDto : IUpdateEntityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
