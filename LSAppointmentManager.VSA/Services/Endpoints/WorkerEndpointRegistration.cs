using LSAppointmentManager.VSA.Features.WorkerFeatures;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSAppointmentManager.VSA.Services.Endpoints
{
    public static class WorkerEndpointRegistration
    {
        private static string _controllerName = "worker";
        public static void AddWorkerEndpoints(this IEndpointRouteBuilder app)
        {
            DeleteWorker.Endpoint deleteWorker = new DeleteWorker.Endpoint();
            deleteWorker.MapEndpoint(app, _controllerName);

            CreateWorker.Endpoint createWorker = new CreateWorker.Endpoint();
            createWorker.MapEndpoint(app, _controllerName);

            UpdateWorker.Endpoint updateWorker = new UpdateWorker.Endpoint();
            updateWorker.MapEndpoint(app, _controllerName);

            GetAllWorker.Endpoint getAllWorker = new GetAllWorker.Endpoint();
            getAllWorker.MapEndpoint(app, _controllerName);

            GetWorkerById.Endpoint getWorker = new GetWorkerById.Endpoint();
            getWorker.MapEndpoint(app, _controllerName);
        }
    }
}
