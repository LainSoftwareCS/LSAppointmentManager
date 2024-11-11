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
    public class SaleProfiles : Profile
    {
        
        public class CreateSaleDetailDto
        {
            public int ProductServiceId { get; set; }
            public decimal Quantity { get; set; }
            public decimal Price { get; set; }
        }
        public class CreateSaleDto
        {
            
            [DisplayName("CreateSaleRequest")]
            public class Request
            {
                public int CustomerId { get; set; }
                public DateTime SaleDate { get; set; }
                public List<CreateSaleDetailDto> Details { get; set; }

            }
            [DisplayName("CreateProductResponse")]
            public class Response
            {
                public int Id { get; set; }
                public int CostumerId { get; set; }
                public DateTime SaleDate { get; set; }
                public decimal Subtotal { get; set; }
                public decimal Discount { get; set; }
                public decimal Taxes { get; set; }
                public decimal Total { get; set; }
                public DateTime CreatedDate { get; set; }
            }
        }
        public class UpdateSaleDto
        {
            [DisplayName("UpdateSaleRequest")]
            public class Request : IUpdateRequest
            {
                public int Id { get; set; }
                public int CostumerId { get; set; }
                public DateTime SaleDate { get; set; }
                public decimal Subtotal { get; set; }
                public decimal Discount { get; set; }
                public decimal Taxes { get; set; }
                public decimal Total { get; set; }
            }
            [DisplayName("UpdateSaleResponse")]
            public class Response
            {
                public int Id { get; set; }
                public int CostumerId { get; set; }
                public DateTime SaleDate { get; set; }
                public decimal Subtotal { get; set; }
                public decimal Discount { get; set; }
                public decimal Taxes { get; set; }  
                public decimal Total { get; set; }
                public DateTime ModifiedDate { get; set; }

            }
        }
        public class GetSaleDto
        {
            [DisplayName("GetSaleResponse")]
            public class Response
            {
                public int Id { get; set; }
                public int CostumerId { get; set; }
                public DateTime SaleDate { get; set; }
                public decimal Subtotal {  get; set; }
                public decimal Discount { get; set; }
                public decimal Taxes { get; set; }
                public decimal Total { get; set; }
                public DateTime ModifiedDate { get; set; }
            }
        }
        public SaleProfiles()
        {
            CreateMap<CreateSaleDto.Request, Sale>();
            CreateMap<Sale, CreateSaleDto.Response>();
            CreateMap<UpdateSaleDto.Request, Sale>();
            CreateMap<Sale, UpdateSaleDto.Response>();
            CreateMap<Sale, GetSaleDto.Response>();
            CreateMap<CreateSaleDetailDto, SaleDetail>();
        }
    }
}
