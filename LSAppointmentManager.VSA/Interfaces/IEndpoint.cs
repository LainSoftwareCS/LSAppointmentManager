using Microsoft.AspNetCore.Routing;

namespace LSAppointmentManager.VSA.Interfaces
{
    public interface IEndpoint
    {
        void MapEndpoint(IEndpointRouteBuilder app, string entityName);
    }
}
