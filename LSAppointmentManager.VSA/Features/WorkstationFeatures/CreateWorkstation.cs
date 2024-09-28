using LSAppointmentManager.Entities;
using LSAppointmentManager.Repositories.Repositories;
using LSAppointmentManager.VSA.Features.AbstractFeatures;
using static LSAppointmentManager.VSA.Profiles.WorkstationProfiles;

namespace LSAppointmentManager.VSA.Features.WorkstationFeatures
{
    public class CreateWorkstation : AbstractCreateFeature<WorkstationRepository, Workstation, WorkstationCreate.Request, WorkstationCreate.Response> 
    {
    }
}
