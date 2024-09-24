using LSAppointmentManager.Entities;
using LSAppointmentManager.Repositories.Contexts;

namespace LSAppointmentManager.Repositories.Repositories
{
    public class SaleRepository : AbstractRepository<Sale>
    {
        public SaleRepository(LSAppointmentManagerContext context) : base(context)
        {
        }
    }
}
