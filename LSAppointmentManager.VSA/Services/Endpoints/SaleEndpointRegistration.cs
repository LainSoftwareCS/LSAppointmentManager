using LSAppointmentManager.VSA.Features.SaleFeatures;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LSAppointmentManager.VSA.Services.Endpoints
{
    public static class SaleEndpointRegistration
    {
        private static string _controllerName = "sale";
        public static void AddSaleEndpoints(this IEndpointRouteBuilder app)
        {
            //DeleteSale.Endpoint deleteSale = new DeleteSale.Endpoint();
            //deleteSale.MapEndpoint(app, _controllerName);

            CreateSale.Endpoint createSale = new CreateSale.Endpoint();
            createSale.MapEndpoint(app, _controllerName);

            //UpdateSale.Endpoint updateSale = new UpdateSale.Endpoint();
            //updateSale.MapEndpoint(app, _controllerName);

            //GetAllSale.Endpoint getAllSale = new GetAllSale.Endpoint();
            //getAllSale.MapEndpoint(app, _controllerName);

            //GetSaleById.Endpoint getSale = new GetSaleById.Endpoint();
            //getSale.MapEndpoint(app, _controllerName);
        }
    }
}
