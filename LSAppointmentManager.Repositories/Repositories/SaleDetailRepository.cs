using LSAppointmentManager.Entities;
using LSAppointmentManager.Repositories.Contexts;
using Microsoft.EntityFrameworkCore;

namespace LSAppointmentManager.Repositories.Repositories
{
    public class SaleDetailRepository : AbstractRepository<SaleDetail>
    {
        public SaleDetailRepository(LSAppointmentManagerContext context) : base(context)
        {
        }
        public async Task<ProductService> GetProductServiceByIdAsync(int productServiceId)
        {
            return await context.ProductServices.FirstOrDefaultAsync(p => p.Id == productServiceId);
        }
    }
}
