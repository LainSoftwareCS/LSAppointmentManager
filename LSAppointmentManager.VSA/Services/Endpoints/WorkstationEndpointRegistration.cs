using LSAppointmentManager.VSA.Features.WorkstationFeatures;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSAppointmentManager.VSA.Services.Endpoints
{
    public static class WorkstationEndpointRegistration
    {
        private static string _controllerName = "workstation";
        public static void AddWorkstationEndpoints(this IEndpointRouteBuilder app)
        {
            DeleteWorkstation.Endpoint deleteWorkstation = new DeleteWorkstation.Endpoint();
            deleteWorkstation.MapEndpoint(app, _controllerName);

            CreateWorkstation.Endpoint createWorkstation = new CreateWorkstation.Endpoint();
            createWorkstation.MapEndpoint(app, _controllerName);

            UpdateWorkstation.Endpoint updateWorkstation = new UpdateWorkstation.Endpoint();
            updateWorkstation.MapEndpoint(app, _controllerName);

            GetAllWorkstation.Endpoint getAllWorkstation = new GetAllWorkstation.Endpoint();
            getAllWorkstation.MapEndpoint(app, _controllerName);

            GetWorkstation.Endpoint getWorkstation = new GetWorkstation.Endpoint();
            getWorkstation.MapEndpoint(app, _controllerName);
        }
    }
}
