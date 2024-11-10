using AutoMapper;
using FluentResults;
using LSAppointmentManager.Entities;
using LSAppointmentManager.Repositories.Repositories;
using LSAppointmentManager.VSA.Features.AbstractFeatures;
using LSAppointmentManager.VSA.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Valibute.Utils;
using static LSAppointmentManager.VSA.Profiles.SaleProfiles;

namespace LSAppointmentManager.VSA.Features.SaleFeatures
{
    public class CreateSale
    {
        public class Endpoint : IEndpoint
        {
            public void MapEndpoint(IEndpointRouteBuilder app, string entityName)
            {
                app.MapPost(entityName, Handler)
                    .WithTags(entityName)
                    .Produces<CreateSaleDto.Response>(200);
            }

            public async Task<IResult> Handler(CreateSaleDto.Request request, CreateSaleDto.Response response, SaleRepository saleRepository, SaleDetailRepository saleDetailRepository, IMapper mapper)
            {
                // Validar si el cliente existe
                var customer = await saleDetailRepository.GetCustomerByIdAsync(request.CustomerId);
                if (customer == null)
                {
                    return Results.BadRequest("Customer not found.");
                }

                // Validar la fecha de la venta
                if (request.SaleDate > DateTime.Now)
                {
                    return Results.BadRequest("Sale date cannot be in the future.");
                }

                // Validar los detalles de la venta
                if (request.Details == null || request.Details.Count == 0)
                {
                    return Results.BadRequest("Sale must have at least one detail.");
                }

                foreach (var detail in request.Details)
                {
                    if (detail.Quantity <= 0)
                    {
                        return Results.BadRequest("Quantity must be greater than zero.");
                    }

                    // Validar que el id del producto sea válido
                    /*var productService = await saleRepository.GetProductServiceByIdAsync(detail.ProductServiceId);
                    if(productService == null)
                    {
                        return Results.BadRequest($"Product/Service with ID {detail.ProductServiceId} not found.");
                    }*/
                    if(detail.Price <= 0)
                    {
                        return Results.BadRequest($"Price {detail.Price} has to be greater than $0.00");
                    }
                }

                //// Aqui va cuando pasan las validaciones, se crea la venta
                //var sale = new Sale
                //{
                //    CustomerId = request.CustomerId,
                //    SaleDate = request.SaleDate,
                //    CreatedDate = DateTime.Now
                //};
                //// Se agregan detalles a la venta
                //foreach (var detail in request.Details)
                //{
                //    var saleDetail = new SaleDetail
                //    {
                //        ProductServiceId = detail.ProductServiceId,
                //        Quantity = detail.Quantity,
                //        Price = detail.Price
                //    };
                //    //sale.SaleDetails.Add(saleDetail);
                //}

                var sale = mapper.Map<Sale>(request);
                var saleDetail = mapper.Map<SaleDetail>(request);

               


                // Realizar cálculos de Subtotal, Descuentos, Impuestos y Total
                /* decimal subtotal = sale.SaleDetails.Sum(d => d.Quantity * d.ProductService.Price); // Supuesto que tienes un precio en el ProductService
                 decimal discount = CalculateDiscount(subtotal); // Lógica de descuento
                 decimal taxes = CalculateTaxes(subtotal); // Lógica de impuestos
                 decimal total = subtotal - discount + taxes;

                 // Crear la venta en la base de datos
                 sale.Subtotal = subtotal;
                 sale.Discount = discount;
                 sale.Taxes = taxes;
                 sale.Total = total;

                 await saleRepository.CreateAsync(sale);

                 // Mapear la respuesta
                 var response = mapper.Map<CreateSaleDto.Response>(sale);

                 return Results.Ok(response);
             }

             // Métodos de cálculo de descuentos e impuestos
             private decimal CalculateDiscount(decimal subtotal)
             {
                 // Lógica de descuento
                 return subtotal * 0.1m; // Ejemplo: 10% de descuento
             }

             private decimal CalculateTaxes(decimal subtotal)
             {
                 // Lógica de impuestos
                 return subtotal * 0.2m; // Ejemplo: 20% de impuestos
             }*/
                return Results.NotFound();
        }
            
        }
    }
}
