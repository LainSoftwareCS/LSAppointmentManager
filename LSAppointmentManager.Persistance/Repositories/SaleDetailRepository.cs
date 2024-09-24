using LSAppointmenteManager.Application.Contracts.Repository;
using LSAppointmentManager.Entities;
using LSAppointmentManager.Persistance.Contexts;

namespace LSAppointmentManager.Persistance.Repositories
{
    public class SaleDetailRepository : AbstractRepository<SaleDetail>, ISaleDetailRepository
    {
        public SaleDetailRepository(AppointmentManagerContext context) : base(context)
        {
        }
    }
}
