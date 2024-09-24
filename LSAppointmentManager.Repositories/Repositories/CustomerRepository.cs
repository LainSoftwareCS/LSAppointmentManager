using LSAppointmentManager.Entities;
using LSAppointmentManager.Repositories.Contexts;

namespace LSAppointmentManager.Repositories.Repositories
{
    public class CustomerRepository : AbstractRepository<Customer>
    {
        public CustomerRepository(LSAppointmentManagerContext context) : base(context)
        {
        }
    }
}
