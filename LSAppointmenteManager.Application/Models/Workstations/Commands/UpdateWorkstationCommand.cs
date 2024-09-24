using LSAppointmentManager.Application.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valibute.Attributes;

namespace LSAppointmentManager.Application.Models.Workstations.Commands
{
    public class UpdateWorkstationCommand : IUpdateEntityCommand
    {
        public int Id { get; set; }
        [VNotEmpty("nombre", ErrorMessage = "El nombre no puede ir vacio")]
        public string Name { get; set; }
    }
}
