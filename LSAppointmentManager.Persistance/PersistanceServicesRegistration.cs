using LSAppointmenteManager.Application.Contracts.Repository;
using LSAppointmentManager.Persistance.Contexts;
using LSAppointmentManager.Persistance.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSAppointmentManager.Persistance
{
    public static class PersistanceServicesRegistration
    {
        public static IServiceCollection AddPersistanceServices(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("LS_DATABASE_APPOINTMENT");
            services.AddDbContext<AppointmentManagerContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            services.AddScoped(typeof(IAbstractRepository<>), typeof(AbstractRepository<>));
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<ISaleDetailRepository, SaleDetailRepository>();
            services.AddScoped<ISaleRepository, SaleRepository>();
            services.AddScoped<IWorkerRepository, WorkerRepository>();
            services.AddScoped<IWorkstationRepository, WorkstationRepository>();
            services.AddScoped<IProductServiceRepository, ProductServiceRepository>();
            services.AddScoped<IProductServiceDetailRepository, ProductServiceDetailRepository>();
            services.AddScoped<IAppointmentRepository, AppointmentRepository>();
            return services;
        }
    }
}
