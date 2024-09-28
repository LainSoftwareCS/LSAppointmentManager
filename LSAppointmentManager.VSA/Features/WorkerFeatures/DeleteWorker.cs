using LSAppointmentManager.Entities;
using LSAppointmentManager.Repositories.Repositories;
using LSAppointmentManager.VSA.Features.AbstractFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSAppointmentManager.VSA.Features.WorkerFeatures
{
    public class DeleteWorker : AbstractDeleteFeature<WorkerRepository, Worker>
    {
    }
}
