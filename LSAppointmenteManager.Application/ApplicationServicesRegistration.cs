using LSAppointmenteManager.Application.Contracts.Repository;
using LSAppointmentManager.Application.Contracts.Features;
using LSAppointmentManager.Application.Features;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Security;
using System.Reflection;

namespace LSAppointmenteManager.Application
{
    public static class ApplicationServicesRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services) 
        {
            var assembly = Assembly.GetExecutingAssembly();
            services.AddAutoMapper(assembly);
            services.AddScoped(typeof(IAbstractRepositoryFeatures<>), typeof(AbstractRepositoryFeatures<>));
            services.AddScoped<IWorkstationFeatures, WorkstationFeatures>();
            return services;
        }
    }
}
