using LSAppointmentManager.Application.Contracts.Features;
using LSAppointmentManager.Application.Features;
using LSAppointmentManager.Application.Models.Workstations;
using LSAppointmentManager.Application.Models.Workstations.Commands;
using LSAppointmentManager.Entities;
using LSAppointmentManager.WebAPI.Utils;
using Valibute.Extensions;

namespace LSAppointmentManager.WebAPI.Endpoints
{
    public static class AddWorkstation
    {
        public static WebApplication AddWorkstationEndpoints(this WebApplication app) {
            var resultHandler = new ResponseUtils("Workstation");


            app.MapGet("/workstation", async (IWorkstationFeatures features) =>
            {
                var entities = await features.GetAllAndMapAsync<GetWorkstationsDto>();
                return resultHandler.HandleResult(entities);
            }).WithOpenApi()
                .Produces<List<GetWorkstationsDto>>(200)
                .WithDisplayName("Get Workstations")
                .Produces(500);

            app.MapGet("/workstation/{id}", async (IWorkstationFeatures features, int id) =>
            {
                var entity = await features.GetByIdAndMapAsync<GetWorkstationDto>(id);
                return resultHandler.HandleResultGet(entity);
            }).WithOpenApi()
               .Produces<GetWorkstationDto>()
               .WithDisplayName("Get Workstation By Id")
               .Produces(404)
               .Produces(500);

            app.MapPost("/workstation", async (IWorkstationFeatures features, SaveWorkstationCommand command) =>
            {
                var entity = await features.CreateAndMapAsync<SaveWorkstationDto, SaveWorkstationCommand>(command);
                return resultHandler.HandleResult(entity);
            }).WithOpenApi()
               .WithValidation<SaveWorkstationCommand>()
               .Produces<SaveWorkstationDto>()
               .WithDisplayName("Create Workstation")
               .Produces(404)
               .Produces(500);

            app.MapPut("/workstation/{id}", async (IWorkstationFeatures features, int id, UpdateWorkstationCommand command) =>
            {
                command.Id = id;
                var entity = await features.UpdateAndMapAsync<UpdateWorkstationDto, UpdateWorkstationCommand>(command);
                return resultHandler.HandleResult(entity);
            }).WithOpenApi()
               .WithValidation<UpdateWorkstationCommand>()
               .Produces<UpdateWorkstationDto>()
               .WithDisplayName("Update Workstation")
               .Produces(404)
               .Produces(500);

            app.MapDelete("/workstation/{id}", async (IWorkstationFeatures features, int id) =>
            {
                var result = await features.DeleteAndMapAsync(id);
                return resultHandler.HandleDelete(result, "Delete successfully!");
            }).WithOpenApi()
               .Produces(200)
               .WithDisplayName("Delete Workstation")
               .Produces(500);

            return app;
        }
    }
}
