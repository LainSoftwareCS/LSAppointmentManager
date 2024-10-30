using AutoMapper;
using LSAppointmentManager.Entities;
using LSAppointmentManager.VSA.Features.AbstractFeatures;
using Microsoft.AspNetCore.Mvc.Formatters.Xml;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valibute.Attributes;

namespace LSAppointmentManager.VSA.Profiles
{
    public class ProductServiceProfiles : Profile
    {
        public class CreateProductServiceDto
        {
            [DisplayName("CreateProductServiceRequest")]
            public class Request
            {
                [VNotEmpty("Nombre", ErrorMessage = "Favor de agregar un nombre válido")]
                public string Name { get; set; }
                [VNotEmpty("Sku", ErrorMessage = "Favor de agregar un Sku válido")]
                public string Sku { get; set; }
                [VNotEmpty("Código de barra", ErrorMessage = "Favor de agregar un código de barra válido")]
                public string Codebar { get; set; }
                [VNotEmpty("Descripción", ErrorMessage = "Favor de agregar una descripción válida")]
                public string Description { get; set; }

                public decimal Price { get; set; }
                public bool HasTexas { get; set; }
                public bool HasTexasIncluded { get; set; }
            }
            [DisplayName("CreateProductServiceResponse")]
            public class Response
            {
                public int Id { get; set; }
                public string Name { get; set; }
                public string Sku { get; set; }
                public string Codebar { get; set; }
                public string Description { get; set; }
                public decimal Price { get; set; }
                public bool HasTaxes { get; set; }
                public bool HasTaxesIncluded { get; set; }
                public DateTime CreatedDate { get; set; }
            }
        }
        public class UpdateProductServiceDto
        {
            [DisplayName("UpdateProductServiceRequest")]
            public class Request : IUpdateRequest
            {
                public int Id { get; set; }
                [VNotEmpty("Nombre", ErrorMessage = "Favor de agregar un nombre válido")]
                public string Name { get; set; }
                [VNotEmpty("Sku", ErrorMessage = "Favor de agregar un Sku válido")]
                public string Sku { get; set; }
                [VNotEmpty("Código de barra", ErrorMessage = "Favor de agregar un código de barra válido")]
                public string Codebar { get; set; }
                [VNotEmpty("Descripción", ErrorMessage = "Favor de agregar una descripción válida")]
                public string Description { get; set; }
                public decimal Price { get; set; }
                public bool HasTaxes { get; set; }
                public bool HasTaxesIncluded { get; set; }
            }
            [DisplayName("UpdateProductServiceResponse")]
            public class Response
            {
                public int Id { get; set; }
                public string Name { get; set; }
                public string Sku { get; set; }
                public string Codebar { get; set; }
                public string Description { get; set; }
                public decimal Price { get; set; }
                public bool HasTaxes { get; set; }
                public bool HasTaxesIncluded { get; set; }
                public DateTime ModifiedDate { get; set; }
            }
        }
        public class GetProductServiceDto
        {
            [DisplayName("GetProductServiceResponse")]
            public class Response
            {
                public int Id { get; set; }
                public string Name { get; set; }
                public string Sku { get; set; }
                public string Codebar { get; set; }
                public string Description { get; set; }
                public decimal Price { get; set; }
                public bool HasTaxes { get; set; }
                public bool HasTaxesIncluded { get; set; }
                public DateTime CreatedDate { get; set; }
                public DateTime ModifiedDate { get; set; }
            }
        }
        public ProductServiceProfiles()
        {
            CreateMap<CreateProductServiceDto.Request, ProductService>();
            CreateMap<ProductService, CreateProductServiceDto.Response>();
            CreateMap<UpdateProductServiceDto.Request, ProductService>();
            CreateMap<ProductService, UpdateProductServiceDto.Response>();
            CreateMap<ProductService, GetProductServiceDto.Response>();
        }
    }
}