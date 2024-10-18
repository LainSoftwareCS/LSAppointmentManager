﻿using LSAppointmentManager.Entities;
using LSAppointmentManager.Repositories.Repositories;
using LSAppointmentManager.VSA.Features.AbstractFeatures;
using static LSAppointmentManager.VSA.Profiles.ProductProfiles;

namespace LSAppointmentManager.VSA.Features.ProductFeatures
{
    public class GetAllProduct : AbstractGetAllFeature<ProductRepository, Product, GetProductDto.Response>
    {
    }
}
