using LSAppointmentManager.VSA.Features.ProductServiceFeatures;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LSAppointmentManager.VSA.Services.Endpoints
{
    public static class ProductServiceEndpointRegistration
    {
        private static string _controllerName = "product";
        public static void AddProductServiceEndpoints(this IEndpointRouteBuilder app)
        {
            DeleteProductService.Endpoint deleteProductService = new DeleteProductService.Endpoint();
            deleteProductService.MapEndpoint(app, _controllerName);

            CreateProductService.Endpoint createProductService = new CreateProductService.Endpoint();
            createProductService.MapEndpoint(app, _controllerName);

            UpdateProductService.Endpoint updateProductService = new UpdateProductService.Endpoint();
            updateProductService.MapEndpoint(app, _controllerName);

            GetAllProductService.Endpoint getAllProductService = new GetAllProductService.Endpoint();
            getAllProductService.MapEndpoint(app, _controllerName);

            GetProductServiceById.Endpoint getProductService = new GetProductServiceById.Endpoint();
            getProductService.MapEndpoint(app, _controllerName);
        }
    }
}
