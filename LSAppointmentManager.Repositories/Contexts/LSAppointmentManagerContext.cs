using LSAppointmentManager.Entities;
using Microsoft.EntityFrameworkCore;

namespace LSAppointmentManager.Repositories.Contexts
{
    public class LSAppointmentManagerContext : DbContext
    {
        public LSAppointmentManagerContext(DbContextOptions<LSAppointmentManagerContext> options) : base(options) { 
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Workstation> Workstations { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<ProductService> ProductServices { get; set; }
        public DbSet<ProductServiceDetail> ProductServiceDetails { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleDetail> SaleDetails { get; set; }
    }
}
