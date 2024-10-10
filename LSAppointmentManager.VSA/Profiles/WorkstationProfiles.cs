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
    public class WorkstationProfiles : Profile
    {
        public class CreateWorkstationDto()
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
        public class UpdateWorkstationDto
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
        public class GetWorkstationDto
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
            CreateMap<CreateWorkstationDto.Request, Workstation>();
            CreateMap<Workstation, CreateWorkstationDto.Response>();
            CreateMap<UpdateWorkstationDto.Request, Workstation>();
            CreateMap<Workstation, UpdateWorkstationDto.Response>();
            CreateMap<Workstation, GetWorkstationDto.Response>();

        }
    }
}
