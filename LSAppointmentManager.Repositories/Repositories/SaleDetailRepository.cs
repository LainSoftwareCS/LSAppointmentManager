using LSAppointmentManager.Entities;
using LSAppointmentManager.Repositories.Contexts;

namespace LSAppointmentManager.Repositories.Repositories
{
    public class SaleDetailRepository : AbstractRepository<SaleDetail>
    {
        public SaleDetailRepository(LSAppointmentManagerContext context) : base(context)
        {
        }
    }
}
