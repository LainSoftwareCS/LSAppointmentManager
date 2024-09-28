using AutoMapper;
using LSAppointmentManager.Entities.Abstract;
using LSAppointmentManager.Repositories.Repositories;
using LSAppointmentManager.VSA.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System.Globalization;
using Valibute.Utils;
namespace LSAppointmentManager.VSA.Features.AbstractFeatures
{
    public abstract class AbstractGetAllFeature<TRepository, TEntity, TResponse>
        where TRepository : AbstractRepository<TEntity>
        where TEntity : AuditableEntity
        where TResponse : class
    {
        public class Endpoint : IEndpoint
        {
            public void MapEndpoint(IEndpointRouteBuilder app, string entityName)
            {
                app.MapGet(entityName, Handler)
                    .WithTags(entityName)
                    .Produces<List<TResponse>>(200);
            }

            public static async Task<IResult> Handler(AbstractRepository<TEntity> repository, IMapper mapper)
            {
                var response = await repository.GetAllAsync();
                return Results.Ok(response.Select(mapper.Map<TResponse>));
            }
        }
    }
}
