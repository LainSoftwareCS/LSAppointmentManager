using LSAppointmentManager.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSAppointmentManager.Persistance.Contexts
{
    public class AppointmentManagerContext : DbContext
    {
        public AppointmentManagerContext(DbContextOptions<AppointmentManagerContext> options) : base(options)
        {
            
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
