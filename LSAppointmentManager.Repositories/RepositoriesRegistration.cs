using LSAppointmentManager.Repositories.Contexts;
using LSAppointmentManager.Repositories.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSAppointmentManager.Repositories
{
    public static class RepositoriesRegistration
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration) {
            services.AddDbContext<LSAppointmentManagerContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("LSAppointmentManagerConnectionString"));
            });

            services.AddTransient(typeof(AbstractRepository<>));
            services.AddTransient<WorkstationRepository>();
            services.AddTransient<CustomerRepository>();
            services.AddTransient<WorkerRepository>();
            services.AddTransient<AppointmentRepository>();

            return services;
        }
    }
}
