using LSAppointmentManager.Application.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSAppointmentManager.Application.Models.ProductService.Commands
{
    public class DeleteProductServiceCommand : IDeleteEntityCommand
    {
        public int Id { get; set; }
    }
}
