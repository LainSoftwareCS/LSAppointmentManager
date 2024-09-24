using LSAppointmentManager.Entities;
using LSAppointmentManager.Repositories.Repositories;
using LSAppointmentManager.VSA.Features.AbstractFeatures;
using static LSAppointmentManager.VSA.Features.WorkstationFeatures.WorkstationProfiles;

namespace LSAppointmentManager.VSA.Features.WorkstationFeatures
{
    public class UpdateWorkstation : AbstractUpdateFeature<WorkstationRepository, Workstation, WorkstationUpdate.Request, WorkstationUpdate.Response>
    {

    }
}
