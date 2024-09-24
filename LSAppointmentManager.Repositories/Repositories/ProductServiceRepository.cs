using LSAppointmentManager.Entities;
using LSAppointmentManager.Repositories.Contexts;

namespace LSAppointmentManager.Repositories.Repositories
{
    public class ProductServiceRepository : AbstractRepository<ProductService>
    {
        public ProductServiceRepository(LSAppointmentManagerContext context) : base(context)
        {
        }
    }
}
