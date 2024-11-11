using LSAppointmentManager.Entities;
using LSAppointmentManager.Repositories.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace LSAppointmentManager.Repositories.Repositories;

public class SaleRepository : AbstractRepository<Sale>
{
    public SaleRepository(LSAppointmentManagerContext context) : base(context)
    {
        
        
    }
    public async Task CreateAsync(Sale sale)
    {
        await context.Sales.AddAsync(sale);
        await context.SaveChangesAsync();
    }
    public async Task<Customer> GetCustomerByIdAsync(int customerId)
    {
        return await context.Customers.FirstOrDefaultAsync(c => c.Id == customerId);
    }
}
