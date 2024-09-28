using AutoMapper;
using LSAppointmentManager.Entities;
using LSAppointmentManager.VSA.Features.AbstractFeatures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valibute.Attributes;

namespace LSAppointmentManager.VSA.Profiles
{
    public class WorkerProfiles : Profile
    {
        public class WorkerCreate
        {
            [DisplayName("CreateWorkerRequest")]
            public class Request
            {
                [VNotEmpty("Nombre", ErrorMessage = "Favor de agregar un nombre valido")]
                public string Name { get; set; }

                [VNotEmpty("Lastname", ErrorMessage = "Favor de agregar un apellido valido")]
                public string Lastname { get; set; }
                public string? Lastname2 { get; set; }
                public DateTime? Birthdate { get; set; }
                [VEmail("Correo" , ErrorMessage = "Favor de agregar un email valido")]
                public string Email { get; set; }
                [VPhone("Telefono", ErrorMessage = "Favor de agregar un telefono valido")]
                public string PhoneNumber { get; set; }
                public int Gender { get; set; }
                public int WorkstationId { get; set; }
            }

            [DisplayName("CreateWorkerResponse")]
            public class Response
            {
                public int Id { get; set; }
                public string Name { get; set; }
                public string Lastname { get; set; }
                public string? Lastname2 { get; set; }
                public DateTime? Birthdate { get; set; }
                public string Email { get; set; }
                public string PhoneNumber { get; set; }
                public int Gender { get; set; }
                public int WorkstationId { get; set; }
                public DateTime CreatedDate { get; set; }
            }
        }

        public class WorkerUpdate
        {
            [DisplayName("UpdateWorkerRequest")]
            public class Request : IUpdateRequest
            {
                public int Id { get; set; }
                [VNotEmpty("Nombre", ErrorMessage = "Favor de agregar un nombre valido")]
                public string Name { get; set; }

                [VNotEmpty("Lastname", ErrorMessage = "Favor de agregar un apellido valido")]
                public string Lastname { get; set; }
                public string? Lastname2 { get; set; }
                public DateTime? Birthdate { get; set; }
                [VEmail("Correo", ErrorMessage = "Favor de agregar un email valido")]
                public string Email { get; set; }
                [VPhone("Telefono", ErrorMessage = "Favor de agregar un telefono valido")]
                public string PhoneNumber { get; set; }
                public int Gender { get; set; }
                public int WorkstationId { get; set; }
            }

            [DisplayName("UpdateWorkerResponse")]
            public class Response
            {
                public int Id { get; set; }
                public string Name { get; set; }
                public string Lastname { get; set; }
                public string? Lastname2 { get; set; }
                public DateTime? Birthdate { get; set; }
                public string Email { get; set; }
                public string PhoneNumber { get; set; }
                public int Gender { get; set; }
                public int WorkstationId { get; set; }
                public DateTime ModifiedDate { get; set; }
            }
        }

        public class WorkerGet
        {
            [DisplayName("GetWorkerResponse")]
            public class Response
            {
                public int Id { get; set; }
                public string Name { get; set; }
                public string Lastname { get; set; }
                public string? Lastname2 { get; set; }
                public DateTime? Birthdate { get; set; }
                public string Email { get; set; }
                public string PhoneNumber { get; set; }
                public int Gender { get; set; }
                public int WorkstationId { get; set; }
                public DateTime CreatedDate { get; set; }
                public DateTime ModifiedDate { get; set; }
            }
        }

        public WorkerProfiles()
        {
            CreateMap<WorkerCreate.Request, Worker>();
            CreateMap<Worker, WorkerCreate.Response>();
            CreateMap<WorkerUpdate.Request, Worker>();
            CreateMap<Worker, WorkerUpdate.Response>();
            CreateMap<Worker, WorkerGet.Response>();
        }
    }
}
