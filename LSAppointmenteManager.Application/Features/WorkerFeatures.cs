using AutoMapper;
using LSAppointmenteManager.Application.Contracts.Repository;
using LSAppointmentManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSAppointmentManager.Application.Features
{
    public class WorkerFeatures : AbstractRepositoryFeatures<Worker>
    {
        public WorkerFeatures(IAbstractRepository<Worker> abstractRepository, IMapper mapper) : base(abstractRepository, mapper)
        {
        }
    }
}
