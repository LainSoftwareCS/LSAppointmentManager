using LSAppointmentManager.Infrastructure.Contracts.Security;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSAppointmentManager.Infrastructure.Impl.Security
{
    public static class SecurityServicesRegistration
    {
        public static IServiceCollection AddSecurityServices(this IServiceCollection services) 
        {
            services.AddSingleton<IUserPasswordService, DemoUserPasswordService>();
            return services;
        }
    }
}
