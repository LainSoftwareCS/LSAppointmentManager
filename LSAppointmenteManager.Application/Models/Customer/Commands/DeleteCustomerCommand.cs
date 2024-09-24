using LSAppointmentManager.Application.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSAppointmentManager.Application.Models.Customer.Commands
{
    public class DeleteCustomerCommand : IDeleteEntityCommand
    {
        public int Id { get; set; }
    }
}
