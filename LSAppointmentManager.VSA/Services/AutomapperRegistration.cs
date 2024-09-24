using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LSAppointmentManager.VSA.Services
{
    public static class AutomapperRegistration
    {
        public static IServiceCollection AddMapping(this IServiceCollection services) {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
