using AutoMapper;
using LSAppointmentManager.Application.Models.Workstations;
using LSAppointmentManager.Application.Models.Workstations.Commands;
using LSAppointmentManager.Entities;

namespace LSAppointmenteManager.Application.Mapping
{
    public class WorkstationProfile : Profile
    {
        public WorkstationProfile()
        {
            ////Commands to entity
            CreateMap<SaveWorkstationCommand, Workstation>();
            CreateMap<UpdateWorkstationCommand, Workstation>();
            CreateMap<DeleteWorkstationCommand, Workstation>();
            ////Commands dto's
            CreateMap<Workstation, SaveWorkstationDto>();
            CreateMap<Workstation, UpdateWorkstationDto>();
            //Query dto's
            CreateMap<Workstation, GetWorkstationDto>();
            CreateMap<Workstation, GetWorkstationsDto>();
        }
    }
}
