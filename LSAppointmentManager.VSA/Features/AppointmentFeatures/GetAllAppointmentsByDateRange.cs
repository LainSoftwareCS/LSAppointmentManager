using AutoMapper;
using LSAppointmentManager.Entities;
using LSAppointmentManager.Repositories.Repositories;
using LSAppointmentManager.VSA.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LSAppointmentManager.VSA.Profiles.AppointmentProfiles;

namespace LSAppointmentManager.VSA.Features.AppointmentFeatures
{
    public class GetAllAppointmentsByDateRange
    {
        public class Endpoint : IEndpoint
        {
            public void MapEndpoint(IEndpointRouteBuilder app, string entityName)
            {
                app.MapGet($"/{entityName}/calendar", Handler)
                    .WithTags(entityName)
                    .Produces<List<GetAllAppointmentsByDateRangeDto.Response>>();
            }

            public async Task<List<GetAllAppointmentsByDateRangeDto.Response>> Handler(int year, int startMonth, int startDay, int endMonth, int endDay, AppointmentRepository appointmentRepository, IMapper mapper)
            {
                var startDate = new DateTime(year, startMonth, startDay,0,0,0);
                var endDate = new DateTime(year, endMonth, endDay,23,59,59);
                List<Appointment> appointments = await appointmentRepository.GetAllByDateRangeAsync(startDate, endDate);
                var result = mapper.Map<List<GetAllAppointmentsByDateRangeDto.Response>>(appointments);
                return result;
            }
        }
    }
}
