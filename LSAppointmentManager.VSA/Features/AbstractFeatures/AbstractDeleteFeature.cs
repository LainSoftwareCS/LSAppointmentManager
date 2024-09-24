using LSAppointmentManager.Entities.Abstract;
using LSAppointmentManager.Repositories.Repositories;
using LSAppointmentManager.VSA.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
namespace LSAppointmentManager.VSA.Features.AbstractFeatures
{
    public abstract class AbstractDeleteFeature<TRepository, TEntity>
        where TRepository : AbstractRepository<TEntity>
        where TEntity : AuditableEntity
    {
        public class Endpoint : IEndpoint
        {
            public void MapEndpoint(IEndpointRouteBuilder app, string entityName)
            {
                app.MapDelete(entityName + "/{id}", Handler);
            }

            public static async Task<IResult> Handler(AbstractRepository<TEntity> repository, int id)
            {
                if (id == 0)
                {
                    return Results.BadRequest("Favor de asignar un id valido");
                }
                await repository.DeleteByIdAsync(id);
                return Results.Ok();
            }
        }
    }
}
