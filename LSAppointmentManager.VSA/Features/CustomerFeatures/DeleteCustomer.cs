using LSAppointmentManager.Entities;
using LSAppointmentManager.Repositories.Repositories;
using LSAppointmentManager.VSA.Features.AbstractFeatures;

namespace LSAppointmentManager.VSA.Features.CustomerFeatures
{
    public class DeleteCustomer : AbstractDeleteFeature<CustomerRepository, Customer>
    {
    }
}
