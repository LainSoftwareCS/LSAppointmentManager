using LSAppointmentManager.Entities;
using LSAppointmentManager.Repositories.Repositories;
using LSAppointmentManager.VSA.Features.AbstractFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LSAppointmentManager.VSA.Features.WorkstationFeatures.WorkstationProfiles;

namespace LSAppointmentManager.VSA.Features.WorkstationFeatures
{
    public class GetWorkstation : AbstractGetByIdFeature<WorkstationRepository, Workstation, WorkstationGet.Response>
    {
    }
}
