using LSAppointmentManager.VSA.Features.CustomerFeatures;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSAppointmentManager.VSA.Services.Endpoints
{
    public static class CustomerEndpointRegistration
    {
        private static string _controllerName = "customer";
        public static void AddCustomerEndpoints(this IEndpointRouteBuilder app)
        {
            DeleteCustomer.Endpoint deleteCustomer = new DeleteCustomer.Endpoint();
            deleteCustomer.MapEndpoint(app, _controllerName);

            CreateCustomer.Endpoint createCustomer = new CreateCustomer.Endpoint();
            createCustomer.MapEndpoint(app, _controllerName);

            UpdateCustomer.Endpoint updateCustomer = new UpdateCustomer.Endpoint();
            updateCustomer.MapEndpoint(app, _controllerName);

            GetAllCustomer.Endpoint getAllCustomer = new GetAllCustomer.Endpoint();
            getAllCustomer.MapEndpoint(app, _controllerName);

            GetCustomerById.Endpoint getCustomer = new GetCustomerById.Endpoint();
            getCustomer.MapEndpoint(app, _controllerName);
        }
    }
}
