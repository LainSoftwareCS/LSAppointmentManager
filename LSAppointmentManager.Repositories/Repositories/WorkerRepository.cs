using LSAppointmentManager.Entities;
using LSAppointmentManager.Repositories.Contexts;

namespace LSAppointmentManager.Repositories.Repositories
{
    public class WorkerRepository : AbstractRepository<Worker>
    {
        public WorkerRepository(LSAppointmentManagerContext context) : base(context)
        {
        }
    }
}
