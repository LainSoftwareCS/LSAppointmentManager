using AutoMapper;
using LSAppointmenteManager.Application.Contracts.Repository;
using LSAppointmentManager.Application.Contracts.Features;
using LSAppointmentManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSAppointmentManager.Application.Features
{
    public class WorkstationFeatures : AbstractRepositoryFeatures<Workstation>, IWorkstationFeatures
    {
        public WorkstationFeatures(IAbstractRepository<Workstation> abstractRepository, IMapper mapper) : base(abstractRepository, mapper)
        {

        }
    }
}
