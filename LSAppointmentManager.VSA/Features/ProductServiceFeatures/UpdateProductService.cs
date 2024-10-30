using LSAppointmentManager.Entities;
using LSAppointmentManager.Repositories.Repositories;
using LSAppointmentManager.VSA.Features.AbstractFeatures;
using static LSAppointmentManager.VSA.Profiles.ProductServiceProfiles;

namespace LSAppointmentManager.VSA.Features.ProductServiceFeatures
{
    public class UpdateProductService : AbstractUpdateFeature<ProductServiceRepository, ProductService, UpdateProductServiceDto.Request, UpdateProductServiceDto.Response>
    {
    }
}
