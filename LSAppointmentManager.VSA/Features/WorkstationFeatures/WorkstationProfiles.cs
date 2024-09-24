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

namespace LSAppointmentManager.VSA.Features.WorkstationFeatures
{
    public class WorkstationProfiles : Profile
    {
        public class WorkstationCreate()
        {
            [DisplayName("WorkstationCreateRequest")]
            public class Request()
            {
                [VNotEmpty("Nombre", ErrorMessage = "Favor de agregar un nombre valido")]
                public string Name { get; set; }
            }
            [DisplayName("WorkstationCreateResponse")]
            public class Response()
            {
                public int Id { get; set; }
                public string Name { get; set; }
                public DateTime CreatedDate { get; set; }
            }
        }
        public class WorkstationUpdate
        {
            [DisplayName("WorkstationUpdateRequest")]
            public class Request : IUpdateRequest
            {
                public int Id { get; set; }
                [VNotEmpty("Nombre", ErrorMessage = "Favor de agregar un nombre valido")]
                public string Name { get; set; }
            }
            [DisplayName("WorkstationUpdateResponse")]
            public class Response
            {
                public int Id { get; set; }
                public string Name { get; set; }
                public DateTime ModifiedDate { get; set; }
            }
        }
        public class WorkstationGet
        {
            [DisplayName("WorkstationGetResponse")]
            public class Response
            {
                public int Id { get; set; }
                public string Name { get; set; }
            }
        }
        public WorkstationProfiles()
        {
            CreateMap<WorkstationCreate.Request, Workstation>();
            CreateMap<Workstation, WorkstationCreate.Response>();
            CreateMap<WorkstationUpdate.Request, Workstation>();
            CreateMap<Workstation, WorkstationUpdate.Response>();
            CreateMap<Workstation, WorkstationGet.Response>();

        }
    }
}
