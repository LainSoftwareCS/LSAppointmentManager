using LSAppointmentManager.Entities;
using LSAppointmentManager.Repositories.Contexts;

namespace LSAppointmentManager.Repositories.Repositories
{
    public class ProductServiceDetailRepository : AbstractRepository<ProductServiceDetail>
    {
        public ProductServiceDetailRepository(LSAppointmentManagerContext context) : base(context)
        {
        }
    }
}
