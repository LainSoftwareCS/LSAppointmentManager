using LSAppointmentManager.Entities;
using LSAppointmentManager.Repositories.Repositories;
using LSAppointmentManager.VSA.Features.AbstractFeatures;
using static LSAppointmentManager.VSA.Profiles.CustomerProfiles;

namespace LSAppointmentManager.VSA.Features.CustomerFeatures
{
    public class UpdateCustomer : AbstractUpdateFeature<CustomerRepository, Customer, CustomerUpdate.Request, CustomerUpdate.Response>
    {
    }
}
