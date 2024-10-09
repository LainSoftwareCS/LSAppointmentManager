using AutoMapper;
using LSAppointmentManager.Entities;
using LSAppointmentManager.Repositories.Repositories;
using LSAppointmentManager.VSA.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valibute.Utils;
using static LSAppointmentManager.VSA.Profiles.AppointmentProfiles;

namespace LSAppointmentManager.VSA.Features.AppointmentFeatures
{
    public class CreateAppointment
    {
        public class Endpoint : IEndpoint
        {
            public void MapEndpoint(IEndpointRouteBuilder app, string entityName)
            {
                app.MapPost(entityName, Handler)
                   .WithTags(entityName)
                   .Produces<AppointmentCreate.Response>(200);
            }

            public async Task<IResult> Handler(AppointmentCreate.Request request, 
                AppointmentRepository appointmentRepository, 
                CustomerRepository customerRepository,
                WorkerRepository workerRepository,
                IMapper mapper)
            {
                var validation = ValibuteUtils.Validate(request);
                if (!validation.IsValid) {
                    return Results.BadRequest(validation.Errors);
                }

                if (!(request.StartDate.Year == request.AppointmentDate.Year
                    && request.StartDate.Month == request.AppointmentDate.Month
                    && request.StartDate.Day == request.AppointmentDate.Day)) {
                    return Results.BadRequest("El inicio de la cita no concuerda con la fecha de la misma");
                }

                if (!(request.EndDate.Year == request.AppointmentDate.Year
                    && request.EndDate.Month == request.AppointmentDate.Month
                    && request.EndDate.Day == request.AppointmentDate.Day))
                {
                    return Results.BadRequest("El final de la cita no concuerda con la fecha de la misma");
                }

                var existAppointment = await appointmentRepository.ExistsByDateRangeAndWorker(request.StartDate, request.EndDate, request.WorkerId);

                if (existAppointment)
                {
                    return Results.BadRequest("No se puede crear una cita en esta fecha, intente con otra fecha");
                }

                if (!await customerRepository.ExistsAny(request.CustomerId))
                {
                    return Results.BadRequest("El paciente asignado no existe");
                }

                if (request.WorkerId != null)
                {
                    if (!await workerRepository.ExistsAny(request.WorkerId.Value))
                    {
                        return Results.BadRequest("El trabajador asignado no existe");
                    }
                }

                var appointment = mapper.Map<Appointment>(request);
                appointment.Guid = Guid.NewGuid();
                appointment = await appointmentRepository.SaveAsync(appointment);

                return Results.Ok(mapper.Map<AppointmentCreate.Response>(appointment));

            }
        }
    }
}
