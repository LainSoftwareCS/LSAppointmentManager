using LSAppointmentManager.Entities;
using LSAppointmentManager.Repositories.Contexts;

namespace LSAppointmentManager.Repositories.Repositories
{
    public class WorkstationRepository : AbstractRepository<Workstation>
    {
        public WorkstationRepository(LSAppointmentManagerContext context) : base(context)
        {
        }
    }
}
