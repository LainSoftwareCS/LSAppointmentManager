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
    public abstract class AbstractCreateFeature<TRepository, TEntity, TRequest, TResponse>
        where TRepository : AbstractRepository<TEntity>
        where TEntity : AuditableEntity
        where TRequest : class
        where TResponse : class
    {
        public class Endpoint : IEndpoint
        {
            public void MapEndpoint(IEndpointRouteBuilder app, string entityName)
            {
                app.MapPost(entityName, Handler)
                    .Produces<TResponse>(200);
                    
            }

            public static async Task<IResult> Handler(AbstractRepository<TEntity> repository, IMapper mapper, TRequest request)
            {
                var validation = ValibuteUtils.Validate<TRequest>(request);
                if (!validation.IsValid)
                {
                    return Results.BadRequest(validation.Errors);
                }

                var entity = mapper.Map<TEntity>(request);
                entity.CreatedDate = DateTime.Now;
                entity = await repository.SaveAsync(entity);
                var response = mapper.Map<TResponse>(entity);

                return Results.Ok(response);
            }
        }
    }
}
