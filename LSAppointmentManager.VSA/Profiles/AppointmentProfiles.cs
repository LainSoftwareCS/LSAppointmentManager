using AutoMapper;
using LSAppointmentManager.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valibute.Attributes;

namespace LSAppointmentManager.VSA.Profiles
{
    public class AppointmentProfiles : Profile
    {
        public class CreateAppointmentDto
        {
            [DisplayName("AppointmentCreateRequest")]
            public class Request
            {
                [VRequired("Paciente", ErrorMessage = "Favor de agregar un cliente")]
                public int CustomerId { get; set; }
                public int? WorkerId { get; set; }
                [VRequired("Fecha", ErrorMessage = "Favor de agregar una fecha")]
                public DateTime AppointmentDate { get; set; }
                [VRequired("Inicio", ErrorMessage = "Favor de agregar una fecha inicio")]
                public DateTime StartDate { get; set; }
                [VRequired("Fin", ErrorMessage = "Favor de agregar una fecha fin")]
                public DateTime EndDate { get; set; }
                public string? Description { get; set; }
            }
            [DisplayName("AppointmentCreateResponse")]

            public class Response
            {
                public Guid Guid { get; set; }
                public int CustomerId { get; set; }
                public int? WorkerId { get; set; }
                public DateTime AppointmentDate { get; set; }
                public DateTime StartDate { get; set; }
                public DateTime EndDate { get; set; }
                public string? Description { get; set; }
                public bool IsCompleted { get; set; } = false;
                public bool IsConfirmed { get; set; } = false;
                public bool IsCancelled { get; set; } = false;
            }
        }

        public class GetAllAppointmentsByDateRangeDto
        {
            [DisplayName("AppointmentGetAllByDateRangeResponse")]
            public class Response
            {
                public int CustomerId { get; set; }
                public string CustomerName { get; set; }
                public int? WorkerId { get; set; }
                public string? WorkerName { get; set; }
                public DateTime AppointmentDate { get; set; }
                public string AppointmentDateString { get; set; } = string.Empty;
                public DateTime StartDate { get; set; }
                //ValueObject
                public int StartDateHour { get; set; }
                public int StartDateMinute { get; set; }
                public DateTime EndDate { get; set; }
                //ValueObject
                public int EndDateHour { get; set; }
                public int EndDateMinute { get; set; }
                public string? Description { get; set; }
                public bool IsCompleted { get; set; } = false;
                public bool IsConfirmed { get; set; } = false;
                public bool IsCancelled { get; set; } = false;
            }
        }
        public AppointmentProfiles()
        {
            CreateMap<CreateAppointmentDto.Request, Appointment>();
            CreateMap<Appointment, CreateAppointmentDto.Response>();
            CreateMap<Appointment, GetAllAppointmentsByDateRangeDto.Response>();

        }
    }
}
