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
    public interface IUpdateRequest
    {
        public int Id { get; set; }
    }

    public abstract class AbstractUpdateFeature<TRepository, TEntity, TRequest, TResponse>
        where TRepository : AbstractRepository<TEntity>
        where TEntity : AuditableEntity
        where TRequest : class, IUpdateRequest
        where TResponse : class
    {
        public class Endpoint : IEndpoint
        {
            public void MapEndpoint(IEndpointRouteBuilder app, string entityName)
            {
                app.MapPut(entityName + "/{id}", Handler)
                    .Produces<TResponse>(200)
                    .WithTags(entityName);
            }

            public static async Task<IResult> Handler(AbstractRepository<TEntity> repository, IMapper mapper, int id, TRequest request)
            {
                request.Id = id;
                var validation = ValibuteUtils.Validate<TRequest>(request);
                if (!validation.IsValid)
                {
                    return Results.BadRequest(validation.Errors);
                }

                var entity = mapper.Map<TEntity>(request);
                entity.ModifiedDate = DateTime.UtcNow;
                entity = await repository.UpdateAsync(entity);
                var response = mapper.Map<TResponse>(entity);

                return Results.Ok(response);
            }
        }
    }
}
