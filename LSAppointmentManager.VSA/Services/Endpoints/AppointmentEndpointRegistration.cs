using LSAppointmentManager.VSA.Features.AppointmentFeatures;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSAppointmentManager.VSA.Services.Endpoints
{
    public static class AppointmentEndpointRegistration
    {
        private static string _controllerName = "appointment";
        public static void AddAppointmentEndpoints(this IEndpointRouteBuilder app)
        {
            CreateAppointment.Endpoint createAppointment = new CreateAppointment.Endpoint();
            createAppointment.MapEndpoint(app, _controllerName);

            GetAllAppointmentsByDateRange.Endpoint getAllAppointmentsByDateRange = new GetAllAppointmentsByDateRange.Endpoint();
            getAllAppointmentsByDateRange.MapEndpoint(app, _controllerName);
        }
    }
}
