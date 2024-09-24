using AutoMapper;
using LSAppointmenteManager.Application.Contracts.Repository;
using LSAppointmentManager.Application.Contracts.Features;
using LSAppointmentManager.Entities;

namespace LSAppointmentManager.Application.Features
{
    public class CustomerFeatures : AbstractRepositoryFeatures<Customer>, ICustomerFeatures
    {
        public CustomerFeatures(IAbstractRepository<Customer> abstractRepository, IMapper mapper) : base(abstractRepository, mapper)
        {
        }
    }
}
