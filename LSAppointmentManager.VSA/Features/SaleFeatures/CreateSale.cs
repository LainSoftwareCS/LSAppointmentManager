using AutoMapper;
using FluentResults;
using LSAppointmentManager.Entities;
using LSAppointmentManager.Repositories.Repositories;
using LSAppointmentManager.VSA.Features.AbstractFeatures;
using LSAppointmentManager.VSA.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Valibute.Utils;
using static LSAppointmentManager.VSA.Profiles.SaleProfiles;

namespace LSAppointmentManager.VSA.Features.SaleFeatures
{
    public class CreateSale
    {
        public class Endpoint : IEndpoint
        {
            public void MapEndpoint(IEndpointRouteBuilder app, string entityName)
            {
                app.MapPost(entityName, Handler)
                    .WithTags(entityName)
                    .Produces<CreateSaleDto.Response>(200);
            }

            public async Task<IResult> Handler(CreateSaleDto.Request request,
                SaleRepository saleRepository,
                SaleDetailRepository saleDetailRepository,
                IMapper mapper)
            {
                var validation = ValibuteUtils.Validate(request);
                if (!validation.IsValid)
                {
                    return Results.BadRequest(validation.Errors);
                }
                if(!(request.)) //Pendiente las validaciones
            }

            
        }
    }
}
