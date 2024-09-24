using LSAppointmenteManager.Application.Contracts.Repository;
using LSAppointmentManager.Entities;
using LSAppointmentManager.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSAppointmentManager.Persistance.Repositories
{
    public class WorkerRepository : AbstractRepository<Worker>, IWorkerRepository
    {
        public WorkerRepository(AppointmentManagerContext context) : base(context)
        {
        }
    }
}
