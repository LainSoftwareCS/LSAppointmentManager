using LSAppointmentManager.Entities;
using LSAppointmentManager.Repositories.Contexts;

namespace LSAppointmentManager.Repositories.Repositories
{
    public class AppointmentRepository : AbstractRepository<Appointment>
    {
        public AppointmentRepository(LSAppointmentManagerContext context) : base(context)
        {
        }
    }
}
