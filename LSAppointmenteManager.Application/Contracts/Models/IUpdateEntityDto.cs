using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSAppointmentManager.Application.Contracts.Models
{
    public interface IUpdateEntityDto
    {
        int Id { get; set; }
        DateTime ModifiedDate { get; set; }
    }
}
