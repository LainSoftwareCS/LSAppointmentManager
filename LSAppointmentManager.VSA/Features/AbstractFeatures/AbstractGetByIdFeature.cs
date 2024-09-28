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
    public abstract class AbstractGetByIdFeature<TRepository, TEntity, TResponse>
        where TRepository : AbstractRepository<TEntity>
        where TEntity : AuditableEntity
        where TResponse : class
    {
        public class Endpoint : IEndpoint
        {
            public void MapEndpoint(IEndpointRouteBuilder app, string entityName)
            {
                app.MapGet(entityName + "/{id}", Handler)
                    .WithTags(entityName)
                    .Produces<TResponse>(200);
            }

            public static async Task<IResult> Handler(AbstractRepository<TEntity> repository, IMapper mapper, int id)
            {
                if (id == 0)
                {
                    return Results.Ok(null);
                }
                var response = await repository.GetByIdAsync(id);
                return Results.Ok(mapper.Map<TResponse>(response));
            }
        }
    }
}
